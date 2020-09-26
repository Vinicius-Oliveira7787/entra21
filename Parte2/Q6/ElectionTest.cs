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
            (string name, string cpf) Jose = ("José","164.231.468.28");
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
            (string name, string cpf) candidate = ("José", "165.321.845.26");
            var candidates = new List<(string name , string cpf)>{candidate};

            // Quando / Ação
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
            (string name, string cpf) Jose = ("José", "216.528.315.95");
            (string name, string cpf) Ana = ("Ana", "161.062.549.26");
            var candidates = new List<(string name, string cpf)>{Jose, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            var candidateJose = election.GetCandidateIdByCpf(Jose.cpf);
            var candidateAna = election.GetCandidateIdByCpf(Ana.cpf);

            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "261.246.005.51");
            (string name, string cpf) ana = ("Ana", "161.326.654.42");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByCpf(fernando.cpf);
            var anaId = election.GetCandidateIdByCpf(ana.cpf);

            // Quando / Ação
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
            (string name, string cpf) fernando = ("Fernando", "315.613.845.20");
            (string name, string cpf) ana = ("Ana", "185.347.249.47");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByCpf(ana.cpf);
            
            // Quando / Ação
            election.Vote(anaId);
            election.Vote(anaId);
            var winners = election.GetWinners();
            var winnerCounter = winners.Count;

            // Deve / Asserções
            Assert.Equal(1, winnerCounter);
            Assert.Equal(anaId, winners[0].id);
            Assert.Equal(2, winners[0].votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "651.151.341.15");
            (string name, string cpf) ana = ("Ana", "161.213.548.65");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByCpf(fernando.cpf);
            var anaId = election.GetCandidateIdByCpf(ana.cpf);
            
            // Quando / Ação
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
        [InlineData(new string[5]{"José","José","José","José", "José"}, new string[0], "Fernando")]
        public void should_return_all_candidates_that_have_the_same_name(string[] candidatesNames, string[] expected, string searchName)
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando", "512.151.184.65");
            (string name, string cpf) ana = ("Ana", "192.168.186.94");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            var candidatesWithSameName = election.AllCandidatesWithSameName(candidates, searchName);

            // Deve / Asserções
            Assert.Equal(expected, candidatesWithSameName);
        }
    }
}