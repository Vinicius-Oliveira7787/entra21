using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        public List<(Guid id, string name, int votes, string cpf)> Candidates { get; set; }
        
        public bool CreateCandidates(List<(string name, string cpf)> candidateNames, string password)
        {
            if (password == "Pa$$w0rd")
            {
                Candidates = candidateNames.Select(candidateName => {
                    return (Guid.NewGuid(), candidateName.name, 0, candidateName.cpf);
                }).ToList();

                return true;
            }
            else
            {
                return false;
            }
        }

        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por CPF

        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        // public Guid GetCandidateIdByName(string name)
        // {
        //     return Candidates.First(x => x.name == name).id;
        // }

        public List<(string, string)> AllCandidatesWithSameName(List<(string name, string cpf)> allCandidateNames, string researchedName)
        {
            return allCandidateNames.Where(item => item.name == researchedName).ToList();
        }

        public Guid GetCandidateIdByCpf(string candidateCpf)
        {
            return Candidates.First(x => x.cpf == candidateCpf).id;
        }

        public void Vote(Guid id)
        {
            Candidates = Candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.votes + 1, "")
                    : candidate;
            }).ToList();
        }

        public List<(Guid id, string name, int votes, string cpf)> GetWinners()
        {
            var winners = new List<(Guid id, string name, int votes, string cpf)>{Candidates[0]};

            for (int i = 1; i < Candidates.Count; i++)
            {
                if (Candidates[i].votes > winners[0].votes)
                {
                    winners.Clear();
                    winners.Add(Candidates[i]);
                }
                else if (Candidates[i].votes == winners[0].votes)
                {
                    winners.Add(Candidates[i]);
                }
            }
            return winners;
        }
    }
}