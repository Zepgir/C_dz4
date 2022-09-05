

Console.Write("Введите ряд чисел, разделенных запятой : ");
string? texter = Console.ReadLine();

texter = texter + ",";    

string DelSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

void Сhecker (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Нужно цифры.");

      }
}

int[] ArrayNumbers(string seriesNew){ 

  int[] arrayNumbers = new int[1];   

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string texter = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      texter += seriesNew[i];
      Сhecker(seriesNew[i]);
      i++;
    }
    arrayNumbers[j] = Convert.ToInt32(texter);    
    if (i < seriesNew.Length-1){
      arrayNumbers = arrayNumbers.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayNumbers;
}

// функция  вывода массива на печать 
void ArrPrint (int[] coll){
  int count = coll.Length;
  int index = 0;
  int max = coll[0];
  int max2 = max;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
   // Console.Write(index);
    
    
     if (coll[index] > max){
     max2 = max;
     max = coll[index]; 
    }
    
    index++;

    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]  max2: ");
   Console.Write(max2);
} 


string seriesNew = DelSpaces(texter);

int[] arrayNumbers =  ArrayNumbers(seriesNew);

ArrPrint (arrayNumbers);