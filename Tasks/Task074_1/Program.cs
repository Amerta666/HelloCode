// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//     Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

using static System.Console;

Clear();

string charsWords = "аисв";
int countCharsInWords = 3
;
PrintAllWords(charsWords,countCharsInWords,"");



void PrintAllWords(string alphabet,int length,string prefix){
  if(length==0) Console.WriteLine(prefix);
  else
   foreach(char c in alphabet) PrintAllWords(alphabet,length-1,prefix+c);
}
