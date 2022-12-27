string[] mainArray={"hello","2","world",":-)"};
// string[] mainArray={"1234","1567","-2","computer scince"};
// string[] mainArray={"Russia","Denmark","Kazan"};
int checkLength=3;
int resultArrayLength=0;
int j=0;

for(int i=0;i<mainArray.Length;i++){
    if(mainArray[i].Length<=checkLength){
        resultArrayLength++;
    }
}
string[] resultArray = new string[resultArrayLength];

for(int i=0;i<mainArray.Length;i++){
    if(mainArray[i].Length<=checkLength){
        resultArray[j]=mainArray[i];
        j++;
    }
}
Console.WriteLine(string.Join(" ", resultArray));