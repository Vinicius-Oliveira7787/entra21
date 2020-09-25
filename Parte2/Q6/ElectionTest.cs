using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace entra21_tests
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            (string name, string cpf) Jose = ("José","");
            var candidates = new List<(string name, string cpf)>{Jose};

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
            Assert.Null(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            (string name, string cpf) candidate = ("José", "");
            var candidates = new List<(string name , string cpf)>{candidate};

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);
            
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(candidate.name, election.Candidates[0].name);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            (string name, string cpf) Jose = ("José", "");
            (string name, string cpf) Ana = ("Ana", "");
            var candidates = new List<(string name, string cpf)>{Jose, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            var candidateJose = election.GetCandidateIdByName(Jose.name);
            var candidateAna = election.GetCandidateIdByName(Ana.name);

            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "");
            (string name, string cpf) ana = ("Ana", "");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByName(fernando.name);
            var anaId = election.GetCandidateIdByName(ana.name);

            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernandoId);
            election.Vote(fernandoId);

            // Deve / Asserções
            var candidateFernando = election.Candidates.Find(x => x.id == fernandoId);
            var candidateAna = election.Candidates.Find(x => x.id == anaId);
            Assert.Equal(2, candidateFernando.votes);
            Assert.Equal(0, candidateAna.votes);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "");
            (string name, string cpf) ana = ("Ana", "");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByName(ana.name);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaId);
            election.Vote(anaId);
            var winners = election.GetWinners();

            // Deve / Asserções
            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].id);
            Assert.Equal(2, winners[0].votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "");
            (string name, string cpf) ana = ("Ana", "");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByName(fernando.name);
            var anaId = election.GetCandidateIdByName(ana.name);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaId);
            election.Vote(fernandoId);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.id == fernandoId);
            var candidateAna = winners.Find(x => x.id == anaId);
            Assert.Equal(1, candidateFernando.votes);
            Assert.Equal(1, candidateAna.votes);
        }

        [Fact]
        public void should_return_candidate_by_cpf()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "512.151.184.65");
            (string name, string cpf) ana = ("Ana", "192.168.186.94");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByCpf(ana.cpf);
            var fernandoId = election.GetCandidateIdByCpf(fernando.cpf);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaId);
            election.Vote(fernandoId);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.id == fernandoId);
            var candidateAna = winners.Find(x => x.id == anaId);
            Assert.Equal(1, candidateFernando.votes);
            Assert.Equal(1, candidateAna.votes);
        }

        [Theory]
        [InlineData(new string[5]{"Ana","Ana","Ana","Fernando", "Ruan"}, new string[3]{"Ana", "Ana", "Ana"}, "Ana")]
        [InlineData(new string[5]{"José","José","José","José", "José"}, new string[5]{"José","José","José", "José", "José"}, "José")]
        public void should_return_all_candidates_that_have_the_same_name(string[] candidatesNames, string[] expected, string searchName)
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "512.151.184.65");
            (string name, string cpf) ana = ("Ana", "192.168.186.94");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var candidatesWithSameName = election.AllCandidatesWithSameName(candidatesNames.ToList(), searchName);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            // election.Vote(anaId);
            // election.Vote(fernandoId);
            // var winners = election.GetWinners();

            // Deve / Asserções
            // var candidateFernando = winners.Find(x => x.id == fernandoId);
            // var candidateAna = winners.Find(x => x.id == anaId);
            // Assert.Equal(1, candidateFernando.votes);
            // Assert.Equal(1, candidateAna.votes);
            Assert.Equal(expected, candidatesWithSameName);
        }
    }
}