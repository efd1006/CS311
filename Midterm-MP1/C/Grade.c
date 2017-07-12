#include <stdio.h>
#include <conio.h>

int main(){
  float prelimGrade,midtermGrade,finalsGrade,average;
  printf("Enter prelim grade: ");
  scanf("%f",&prelimGrade);
  printf("Enter midterm grade: ");
  scanf("%f",&midtermGrade);
  printf("Enter finals grade: ");
  scanf("%f",&finalsGrade);
  average = (prelimGrade + midtermGrade + finalsGrade)/3;
  printf("Average: %.2f",average);
  if(average >= 75){
    printf("\nRemarks: :)");
  }else{
    printf("\nRemarks: :(");
  }
}
