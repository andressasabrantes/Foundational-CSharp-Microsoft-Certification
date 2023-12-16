/* 
Visão geral do projeto
Você está desenvolvendo uma Calculadora de GPA do Aluno que ajudará a calcular a média geral de notas dos alunos. Os parâmetros para o aplicativo são os seguintes:

Você recebe o nome do aluno e as informações da classe.
Cada classe tem um nome, a nota do aluno e o número de horas de crédito da disciplina.
O aplicativo precisa executar operações matemáticas básicas para calcular o GPA do aluno especificado.
O aplicativo precisa produzir/exibir o nome do aluno, as informações da classe e o GPA.
Para calcular o GPA, faça o seguinte:

Multiplique o valor da nota de uma disciplina pelo número de horas de crédito dessa disciplina.
Faça isso para cada disciplina e adicione esses resultados juntos.
Divida a soma resultante pelo número total de horas de crédito.
Você receberá o seguinte exemplo de informações de disciplina e GPA de um aluno:

Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
 */

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");
