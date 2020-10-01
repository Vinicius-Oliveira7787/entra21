using System;
using System.Collections.Generic;

namespace Entra21_2
{
    class Program
    {
        public int[] Exercise1A()
        {
            var array = new int[10];
            for (int i = 1; i < 11; i++)
            {
                array[i - 1] = i;
            }
            return array;
        } 
      
        public int[] Exercise1B()
        {
            var arrayB = new int[10];
            for (int i = 10; i > 0; i--)
            {
                arrayB[arrayB.Length - i] = i;
            }
            return arrayB;
        }
    
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }
            return numbers;
        }
    
        public int Exercise2()
        {
            var finalResult = 0;
            for (int i = 1; i < 101; i++)
            {
                finalResult += i;
            }
            return finalResult;
        }
    
        public int[] Exercise3()
        {
            var numberOddBelowTwoHundred = new int[199];
            var counter = 0;
            for (int i = 1; i < 200; i+= 2)
            {
                numberOddBelowTwoHundred[counter] = i;
                counter++;
            }
            return numberOddBelowTwoHundred;
        }
    
        public double Exercise4(List<int> ages)
        {
            // 4)Calcular a média de idade de uma turma qualquer. 
            // O algoritmo deve parar quando for digitada a idade igual a zero.    
            
            double sum = 0;
            var answers = ages.Count;
            foreach (var item in ages)
            {
                if (item == 0)
                {
                    break;
                }
                sum += item;
            }
            var average = (sum / answers);
            
            return average;
        }
    
        public double Exercise5(List<int> womenAge)
        {
            //5)Criar um algoritmo que peça o nome e a idade de 5 mulheres. 
            // Após informar estes dados, o programa deve mostrar apenas 
            // porcentagem de mulheres que estão com idade entre 18 e 35. 
            var sum = 0;
            var counter = womenAge.Count;
            
            foreach (var item in womenAge)
            {
                if (item > 17 && item < 36)
                {
                    sum++;
                }
            }
            
            var percent = (sum * 100) / counter;
            return percent;
        }
    
        public string Exercise6Cadastro()
        {
            //6)Criar um algoritmo que simule uma urna eletrônica. 
            // Esta urna deve possuir dois candidatos e possui três modos. 
            // O primeiro é o modo de CADASTRO, onde o sistema pergunta o nome de cada um dos dois candidatos. 
            // Por medidas de segurança, para poder cadastrar um candidato na urna 
            // o sistema deve solicitar ao usuário a senha para poder ter acesso (a senha do sistema é Pa$$w0rd). 

            var password = "wrong_password";
            while (password != "Pa$$w0rd")
            {
                if (password == "Pa$$w0rd")
                {
                    break;
                }
                password = "Pa$$w0rd";
            }
            return password;
        }
     
        public string Exercise6Votos(List<string> candidatesNames)
        {
            //List<string> candidatesNames
            //O segundo modo é o modo de votos, onde o usuário informa 1 para votar no primeiro candidato 
            // e 2 para votar no segundo candidato. 
            // O terceiro modo, é o modo de apuração de votos, 
            // onde o sistema verifica qual candidato tem mais votos. Caso o número de votos seja igual, 
            // o sistema deve imprimir a mensagem "SEGUNDO TURNO", 
            // caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.
            var firstCandidateVotes = 2;
            var secondCandidateVotes = 0;
            // var firstCandidateVotes = 0;
            // var secondCandidateVotes = 2;
            var winner = "";
            
            if (firstCandidateVotes > secondCandidateVotes)
            {
                winner = candidatesNames[0];
            }
            if (firstCandidateVotes < secondCandidateVotes)
            {
                winner = candidatesNames[1];
            }
            return winner;
        }
    
        public string Exercise6SecondTurn(List<string> candidatesNames)
        {
            // O terceiro modo, é o modo de apuração de votos, 
            // onde o sistema verifica qual candidato tem mais votos. Caso o número de votos seja igual, 
            // o sistema deve imprimir a mensagem "SEGUNDO TURNO", 
            // caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.

            var firstCandidateVotes = 2;
            var secondCandidateVotes = 2;
            var winner = "";
            
            if (firstCandidateVotes > secondCandidateVotes)
            {
                winner = candidatesNames[0];
            }
            else if (firstCandidateVotes < secondCandidateVotes)
            {
                winner = candidatesNames[1];
            }
            else if(firstCandidateVotes == secondCandidateVotes)
            {
                winner = "SEGUNDO TURNO";
            }
            return winner;
        }
    
        public double Exercise7()
        {
        // 7)Calcular a quantidade de dinheiro gasta por um fumante. 
        // Dados: o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.
        var years = 2 * 365;
        var cigarreteDays = 7;
        var boxPrice = 2.30;
        
        var spentAverage = years * cigarreteDays * boxPrice;
        return spentAverage;
        }
    
        public string Exercise8True()
        {
            int x = 6;
            int y = 3;
            string k = "";
            if (x % y == 0)
            {
            k = "multiplo";
            }
            return k;
        }
     
        public string Exercise8False()
        {
            int x = 3;
            int y = 6;
            string k = "";

            if (x % y != 0)
            {
                k = "não é multiplo";
            }
            return k;
        }
     
        public string Exercise9True()
        {
            // 9)Fazer um algoritmo para ler 03 números reais do teclado e verificar 
            // se o primeiro é maior que a soma dos outros dois.

            var firstNumber = 8;
            var secondNumber = 10;
            var thirdNumber = 1;
            var biggestNumber = "";
            var sum = firstNumber + thirdNumber;

            if (secondNumber > sum)
            {
                biggestNumber += "is bigger";
            }
            return biggestNumber;
        }
     
        public string Exercise9False()
        {
            // 9)Fazer um algoritmo para ler 03 números reais do teclado e verificar 
            // se o primeiro é maior que a soma dos outros dois.

            var firstNumber = 8;
            var secondNumber = 10;
            var thirdNumber = 3;
            var biggestNumber = "";
            var sum = firstNumber + thirdNumber;

            if (secondNumber > sum)
            {
                biggestNumber += "is bigger";
            }
            else if(secondNumber < sum)
            {
                biggestNumber += "isn't bigger";
            }
            return biggestNumber;
        }
     
        public string Exercise9Equal()
        {
            // 9)Fazer um algoritmo para ler 03 números reais do teclado e verificar 
            // se o primeiro é maior que a soma dos outros dois.

            var firstNumber = 8;
            var secondNumber = 10;
            var thirdNumber = 2;
            var biggestNumber = "";
            var sum = firstNumber + thirdNumber;

            if (secondNumber > sum)
            {
                biggestNumber += "is bigger";
            }
            else if (secondNumber < sum)
            {
                biggestNumber += "isn't bigger";
            }
            else if (secondNumber == sum)
            {
                biggestNumber += "equal";
                
            }
            return biggestNumber;
        }
     
        public string Exercise10FirstNumberBigger() 
        {
            var biggestNumber = "";
            var firstNumber = 50;
            var secondNumber = 49;
            if (firstNumber > secondNumber)
            {
                biggestNumber += "FirstNumber is bigger";
            }
            return biggestNumber;
        }
    
        public string Exercise10SecondNumberBigger() 
        {
            var biggestNumber = "";
            var firstNumber = 4562124;
            var secondNumber = 24134652;
            if (firstNumber > secondNumber)
            {
                biggestNumber += "FirstNumber is bigger";
            }
            if (firstNumber < secondNumber)
            {
                biggestNumber += "SecondNumber is bigger";
            }
            return biggestNumber;
        }
    
        public string Exercise10Equal() 
        {
            var biggestNumber = "";
            var firstNumber = 50;
            var secondNumber = 50;
            if (firstNumber > secondNumber)
            {
                biggestNumber += "FirstNumber is bigger";
            }
            else if (firstNumber < secondNumber)
            {
                biggestNumber += "SecondNumber is bigger";
            }
            else
            {
                biggestNumber += "They are equal";
            }
            return biggestNumber;
        }
    
        public double Exercise11()
        {
        // 11)Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, 
        // calcular e imprimir o quociente do primeiro pelo segundo. Caso contrário, 
        // imprimir a mensagem: "DIVISÃO POR ZERO".

        var firstAndSecondNumer = new List<double>(){10, 5};
        var returnedResult = firstAndSecondNumer[0] / firstAndSecondNumer[1];

        return returnedResult;
        }
    
        public string Exercise11ButIsDivisionByZero()
        {

        var firstAndSecondNumer = new List<double>(){10, 0};
        var returnedResult = "";
        for (int i = 0; i < firstAndSecondNumer.Count; i++)
        {
            if (firstAndSecondNumer[i] == 0)
            {
                returnedResult = "DIVISÃO POR ZERO";
            }
        }
        return returnedResult;
        }
    
        public int Exercise12()
        {
            //12)Ler 4 números inteiros e calcular a soma dos que forem pares.

            var fourNumber = new List<int>(){1,2,3,4};
            var sum = 0;

            foreach (var item in fourNumber)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    
        public double Exercise13()
        {

        var numbers = new List<double>(){1,2,3,4,5,6,7,8,9,10};
        var biggestNumber = 0.0;

        foreach (var item in numbers)
        {
            if (item > biggestNumber)
            {
                biggestNumber = item;
            }    
        }
        return biggestNumber;
        }
     
        public string Exercise14(double firstNumber, double secondNumber, double thirdNumber)
        {
            //14)Ler três valores e colocá-los em ordem.
            var temporary = 0.0;
            var finalResult = "";
            
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                temporary = thirdNumber;
                thirdNumber = firstNumber;
                firstNumber = temporary;
            }
            
            if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                temporary = thirdNumber;
                thirdNumber = secondNumber;
                secondNumber = temporary;
            }
            
            if (firstNumber > secondNumber)
            {
                temporary = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temporary;
            }
            finalResult += $"{firstNumber},{secondNumber},{thirdNumber}";

            return finalResult;
        }
     
        public string Exercise15(List<double> numbers)
        {
        //15)Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.
        var numbersMultipleByFive = 0;
        var numbersMultipleByThree = 0;
        foreach (var item in numbers)
        {
            if (item % 5 == 0)
            {
                numbersMultipleByFive++;
            }
            if (item % 3 == 0)
            {
                numbersMultipleByThree++;
            }
        }
        var finalResult = $"{numbersMultipleByThree},{numbersMultipleByFive}";
        return finalResult;
        }
    
        public string Exercise16(List<double> Salary)
        {
        // 16)Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a redução do imposto descrito ao lado:
        // Menor ou igual a R$ 600,00 - ISENTO
        // Maior que R$ 600,00 e menor ou igual a 100 - 20% desconto
        // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
        // Maior que R$ 2.000,00 - 30% desconto
        var returnedSalaryDiscount = "";

        for (int i = 0; i < Salary.Count; i++)
        {
            if (Salary[i] <= 600)
            {
                returnedSalaryDiscount += $"ISENTO,";    
                continue;
            }

            if(Salary[i] > 600 && Salary[i] < 1200)
            {
                //returnedSalaryDiscount += $"{Salary[i] * 0.80}";
                returnedSalaryDiscount += " 20%,";
                continue;
            }

            if(Salary[i] > 1200 && Salary[i] < 2000)
            {
                returnedSalaryDiscount += " 25%,";
                continue;
            }

            if(Salary[i] > 2000)
            {
                returnedSalaryDiscount += " 30%";
            }
        }

        return returnedSalaryDiscount;
        }
     
        public List<double> Exercise17(List<int> tabuada)
        {
        //17)Imprimir a tabuada de qualquer número fornecido pelo usuário até que o usuário forneça o valor –1.

        var returnoTabuada = new List<double>();
        foreach (var item in tabuada)
        {
            for (int i = 1; i < 11; i++)
            {
                var temporary = item * i;
                returnoTabuada.Add(temporary);
            }
        }
            return returnoTabuada;
        }
    
        public List<string> Exercise18(List<double> apples)
        {
        // 18)As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, 
        // e R$ 1,00 se forem compradas pelo menos 12. 
        // Escreva um programa que leia o número de maçãs compradas, calcule e
        // escreva o custo total da compra. 
        (double menosDeUmaDuzia, double maisDeUmaDuzia) apple = (1.30, 1.00);
        var answers = new List<string>();

        foreach (var item in apples)
        {
            if (item >= 12)
            {
                answers.Add($"R${item * apple.maisDeUmaDuzia}");
            }
            if (item < 12)
            {
                answers.Add($"R${item * apple.menosDeUmaDuzia}");
            }
        }
        return answers;
        }
     
        public List<double> ExerciseArrays1Q1(List<double> arrayA, List<double> ArrayB)
        {
        //Leia dois arrays A e B com 15 elementos. Construir um array C, 
        //onde cada elemento de C é a subtração do elemento correspondente de A com B. No final imprimir o array C.

        var arrayC = new List<double>();

        for (int i = 0; i < arrayA.Count; i++)
        {
            arrayC.Add(arrayA[i] - ArrayB[i]);
        }
        
        return arrayC;
        }
    
        public List<double> ExerciseArrays1Q2Direto(List<double> arrayA)
        {
        //Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        var formaDireta = new List<double>(){};

        for (int i = 0; i < arrayA.Count; i++)
        {
            formaDireta.Add(arrayA[i]);
        }
        return formaDireta;
        }
    
        public List<double> ExerciseArrays1Q2Inverso(List<double> arrayA)
        {
        //Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        var formaInversa = new List<double>(){};

        for (int i = arrayA.Count - 1; i >= 0 ; i--)
        {
            formaInversa.Add(arrayA[i]);
        }
        return formaInversa;
        }
    
        public string ExerciseArrays1Q3True(List<double> arrayA)
        {
//Leia 10 elementos e armazene em um array A. Em seguida, 
// solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
// Caso, seja verdade imprima a mensagem: “O número existe no array”, caso contrário “Número inexistente”.

        var exist = false;
        var search = 25;
        //var search = 26;
        foreach (var item in arrayA)
        {
            if (search == item)
            {
                exist = true;
            }
        }
        
        var answer = exist ? "O número existe no array" : "Número inexistente";
        return answer;
        }
    
        public string ExerciseArrays1Q3False(List<double> arrayA)
        {

        var exist = false;
        // var search = 25;
        var search = 26;
        foreach (var item in arrayA)
        {
            if (search == item)
            {
                exist = true;
            }
        }
        
        var answer = exist ? "O número existe no array" : "Número inexistente";
        return answer;
        }
    
        public string ExerciseArrays1Q4True()
        {
            // 4-Leia dois arrays A e B com 10 elementos.  
            // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.

            const int arrayLenght = 10;
            
            var firstArray = new double?[arrayLenght] {0, 2, 3, 1, 4, 25, 7, 8, 9, 15};
            var secondArray = new double[arrayLenght] {7, 1, 9, 1, 5, 10, 578, 29, 51, 2};
            var saoIguais = false;
            var arraySaoIguais = true;

            foreach (var item in secondArray)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if(firstArray[j] == item) 
                    {
                        saoIguais = true;
                        firstArray[j] = null;
                        arraySaoIguais = true;
                        break;
                    }
                    if(!saoIguais)
                    {
                        arraySaoIguais = false;
                    }
                }
            }
            
            var message = arraySaoIguais ? "São iguais" : "Não são iguais";
            return message;
        } 
   
        public string ExerciseArrays1Q4False()
        {
            // 4-Leia dois arrays A e B com 10 elementos.  
            // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.

            const int arrayLenght = 10;
            
            var firstArray = new double?[arrayLenght] {0, 2, 3, 1, 4, 25, 7, 8, 9, 15};
            var secondArray = new double[arrayLenght] {45, 5, 10, 12, 5, 10, 578, 29, 51, 54};
            var saoIguais = false;
            var arraySaoIguais = true;

            foreach (var item in secondArray)
            {
                for (int j = 0; j < arrayLenght; j++)
                {
                    if(firstArray[j] == item) 
                    {
                        saoIguais = true;
                        firstArray[j] = null;
                        arraySaoIguais = true;
                        break;
                    }
                    if(!saoIguais)
                    {
                        arraySaoIguais = false;
                    }
                }
            }
            
            var message = arraySaoIguais ? "São iguais" : "Não são iguais";
            return message;
        } 
     
        public string ExerciseArrays1Q5()
        {
        //Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
        //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média

        var myList = new List<double>(){2,4,6,8};
        var sum = 0.0;
        (int aboveAverage, int average, int belowAverage) counter = (0, 0, 0);
        for(int i = 0; i < myList.Count; i++)
        {
            sum += myList[i];
        }
        var average = sum / myList.Count;
        foreach (var item in myList)
        {
            if (item > average)
            {
                counter.aboveAverage++;//2
                continue;
            }
            
            if (item == average)
            {
                counter.average++;
                continue;
            }
            counter.belowAverage++;//2
        }
        var returnedValues = $"{counter.aboveAverage}, {counter.average}, {counter.belowAverage}";
        return returnedValues;
        }
    
        public List<double> ExerciseArrays2Q1()
        {
//Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.            
        var firstList = new List<double>(){1, 2, 3, 4};
        var secondList = new List<double>(){5, 6, 7, 8};
        var returnedList = new List<double>();//answers: 0,5, 2, 4, 5, 8, 12,5, 18, 24,5, 32
            
        for (int i = 0; i < firstList.Count; i++)
        {
            returnedList.Add((firstList[i] * firstList[i]) / 2);  
        }
        
        for (int i = 0; i < firstList.Count; i++)
        {
            returnedList.Add((secondList[i] * secondList[i]) / 2);  
        }
        return returnedList;
        }
     
        public bool ExerciseArrays2Q2()
        {
//Dado um vetor qualquer com 10 números,faça um programa que informa se há ou não números repetidos nesse vetor.

        var semCriatividade = new List<double>(){1, 165, 21, 13, 541, 48, 416, 151, 25, 25};
        var toComPreguica = false;

        foreach (var item in semCriatividade)
        {
            for (int i = 0; i < semCriatividade.Count; i++)
            {
                if (item == semCriatividade[i])
                {
                    toComPreguica = true;
                }
            }
        }
        return toComPreguica;
        }
     
        public string ExerciseArrays2Q3YesOrNo()
        {
// Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não 
// de um novo produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado
// e a sua resposta (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, 
// fazer um algoritmo que calcule e escreva:
// • O número de pessoas que responderam sim; //done
// • O número de pessoas que responderam não; //done
// • A percentagem de pessoas do sexo feminino que responderam sim;
// • A percentagem de pessoas do sexo masculino que responderam não;            
        var peopleInterviewed = new List<string>(){"yes","yes","yes","yes","no","no","no","no","no","no"};
        var peopleLiked = 0;
        var peopleDisliked = 0;

        foreach (var item in peopleInterviewed)
        {
            var temporary = item == "yes" ? peopleLiked++ : peopleDisliked++;
        }
        var returnedAnswers = $"{peopleLiked} pessoas gostaram, {peopleDisliked} pessoas não gostaram";
        return returnedAnswers;
        }
      
        public string ExerciseArrays2Q3PercentageMenDislikedWomenLiked()
        {    
        var peopleInterviewed = new List<string>(){"yes","yes","yes","yes","no","no","no","no","no","no"};
        var peopleInterviewedMenAndWomen = new List<string>()
        {"man","woman","man","woman","man","woman","man","woman","man","woman"};
        (int menDisliked, int womenLiked) Interview = (0,0);
        
        for (int i = 0; i < peopleInterviewedMenAndWomen.Count; i++)
        {
            if (peopleInterviewedMenAndWomen[i] == "man" &&  peopleInterviewed[i] == "no")
            {
                Interview.menDisliked++;
            }
            if (peopleInterviewedMenAndWomen[i] == "woman" &&  peopleInterviewed[i] == "yes")
            {
                Interview.womenLiked++;
            }
        }
        var percentWomenLiked = (Interview.womenLiked * 100) / peopleInterviewed.Count;
        var percentMenDisliked = (Interview.menDisliked * 100) / peopleInterviewed.Count;

var returnedAnswers = $"{percentMenDisliked}% dos homens não gostaram, {percentWomenLiked}% das mulheres gostaram";
        return returnedAnswers;
        }
    
        public double ExerciseArrays2Q4()
        {
//Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
// A do tipo vetor. No final, apresente o total da soma de todos os elementos // que sejam impares.

        var listaDoVetorDeUmaMatrizDeCincoElementosLol = new List<double>(){1.5, 2.75, 4, 4, 15.2,};
        var totalSum = 0.0;

        for (int i = 0; i < listaDoVetorDeUmaMatrizDeCincoElementosLol.Count; i++)
        {
            if (listaDoVetorDeUmaMatrizDeCincoElementosLol[i] % 2 != 0)
            {
                totalSum += listaDoVetorDeUmaMatrizDeCincoElementosLol[i];
            }
        }
        return totalSum;
        }
     
        public int ExerciseArrays2Q5()     
        {
//Contar quantos valores de um vetor de 10 posições são positivos.
        var lazyList = new List<double>(){-1, 1.5, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15};

        var positiveValuesCounter = 0;
        for (int i = 0; i < lazyList.Count; i++)
        {
            if (lazyList[i] > 0)
            {
                positiveValuesCounter++;
            }
        }
        return positiveValuesCounter;
        }
    
        public string ExerciseArrays2Q6()     
        {
//Ler um vetor de 10 posições (aceitar somente números positivos). 
//Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.    

        var lazyList = new List<double>(){-1, 1.5, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15};

        (double biggestNumber, int biggestNumberIndex) exercise = (0.0, 0);

        for (int i = 0; i < lazyList.Count; i++)
        {
            if(lazyList[i] > exercise.biggestNumber)
            {
                exercise.biggestNumber = lazyList[i];
                exercise.biggestNumberIndex = i;
            }
        }
        var abc = $"Maior número: {exercise.biggestNumber}, Posição do index: {exercise.biggestNumberIndex}";
        return abc;
        }
     
        public double ExerciseArrays2Q7()
        {
//Crie e popule um vetor A e imprima na tela o número de vezes que existe um número 
//residindo na mesma posição do vetor que seu valor numérico.            
        var numbers = new List<double>(){0, 1, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15};
        var equalNumbers = 0.0;

        for (int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i] == i)
            {
                equalNumbers++;
            }
        }
        return equalNumbers;
        } 
    
        public double ExerciseArrays2Q8(List<string> letters)    
        {
//Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
//No final, imprima quantas destas são vogais.

        var returnedNumberOfvowels = 0;
        for (int i = 0; i < letters.Count; i++)
        {
            if (letters[i] == "a" || letters[i] == "e" || letters[i] == "i" || letters[i] == "o" || letters[i] == "u")
            {
                returnedNumberOfvowels++;
            }
        }
        return returnedNumberOfvowels;
        }
     
        public string ExerciseArrays2Q9(List<string> letters)
        {
//Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
//No final, imprima a string resultante da soma das strings que residem em índices pares.

        var resultantString = "";
        for (int i = 0; i < letters.Count; i++)
        {
            if (i % 2 == 0)
            {
                resultantString += letters[i]; 
            }
        }
        return resultantString;
        }
    }
}
        //static void Main(string[] args)
		// {
 
        //     System.Console.WriteLine("\nCom os algarismos 1, 4, 6 e 8 pode-se formar vários números de três algarismos distintos.");
        //     System.Console.WriteLine("Qual é a soma de todos esses números?");
        //     (int centena, int dezena, int unidade, int finalResult) resultado = (0, 0, 0, 0);
            
        //     resultado.centena = 6*(100+400+600+800);
        //     resultado.dezena = 6*(10+40+60+80);
        //     resultado.unidade = 6*(1+4+6+8);
        //     resultado.finalResult = resultado.centena + resultado.dezena + resultado.unidade;
        //     System.Console.WriteLine($"\nR: {resultado.finalResult}");
		// }