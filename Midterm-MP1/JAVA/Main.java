import java.io.*;
class Grade{
  private float prelimGrade;
  private float midtermGrade;
  private float finalsGrade;
  private float average;
  Grade(float p, float m, float f){
    this.prelimGrade = p;
    this.midtermGrade = m;
    this.finalsGrade = f;
    this.average = (p+m+f)/3;
    System.out.println("Average: "+getAverage());
    System.out.println("Remarks: "+getremarks());
  }
  public String getremarks(){
    return (average >= 75) ? ":)":":(";
  }
  public float getAverage(){
    return average;
  }
}
class Main{
  public static void main(String[] args) throws Exception{
    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    System.out.print("Enter prelim grade: ");
    float pg = Float.parseFloat(br.readLine());
    System.out.print("Enter midterm grade: ");
    float mg = Float.parseFloat(br.readLine());
    System.out.print("Enter finals grade: ");
    float fg = Float.parseFloat(br.readLine());
    Grade g = new Grade(pg,mg,fg);
  }
}
