/*
You're developing a Student Grading application that automates the calculation of current grades for each student in a class The parameters for your application are:

You're given a short list of four students and their five assignment grades.
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
Final scores are calculated as an average of the five assignment scores.
Your application needs to perform basic math operations to calculate the final grades for each student.
Your application needs to output/display each student’s name and final score.

Leonardo: 93, 87, 98, 95, 100
Jimena: 80, 83, 82, 88, 85
Liliana:   84, 96, 73, 85, 79
Javier:  90, 92, 98, 100, 97

The teacher requires that the calculated grades for each student are displayed as follows:
Student     Grade
Leonardo      94.6  A
Jimena     83.6  B
Liliana     83.4  B
Javier       95.4  A
*/

// initialize variables - graded assignments 
int currentAssignments = 5;

int leonardo1 = 93;
int leonardo2 = 87;
int leonardo3 = 98;
int leonardo4 = 95;
int leonardo5 = 100;

int jimena1 = 80;
int jimena2 = 83;
int jimena3 = 82;
int jimena4 = 88;
int jimena5 = 85;

int liliana1 = 84;
int liliana2 = 96;
int liliana3 = 73;
int liliana4 = 85;
int liliana5 = 79;

int javier1 = 90;
int javier2 = 92;
int javier3 = 98;
int javier4 = 100;
int javier5 = 97;

decimal leonardoAverage = Math.Round((decimal)(leonardo1 + leonardo2 + leonardo3 + leonardo4 + leonardo5)/(decimal) currentAssignments, 1);
decimal jimenaAverage = Math.Round((decimal)(jimena1 + jimena2 + jimena3 + jimena4 + jimena5)/(decimal) currentAssignments, 1);
decimal lilianaAverage = Math.Round((decimal)(liliana1 + liliana2 + liliana3 + liliana4 + liliana5)/(decimal) currentAssignments, 1);
decimal javierAverage = Math.Round((decimal)(javier1 + javier2 + javier3 + javier4 + javier5)/(decimal) currentAssignments, 1);

string leonardoGrade = "";
string jimenaGrade = "";
string lilianaGrade = "";
string javierGrade = "";

if (leonardoAverage > 90){
    leonardoGrade = "A";
}else{
    leonardoGrade = "B";
}

if (jimenaAverage > 90) {
    jimenaGrade = "A";
} else {
    jimenaGrade = "B";
}

if (lilianaAverage > 90){
    lilianaGrade = "A";
}else{
    lilianaGrade = "B";
}

if (javierAverage > 90) {
    javierGrade = "A";
} else {
    javierGrade = "B";
}

Console.WriteLine($"Student\t\tGrade\nLeonardo\t{leonardoAverage} {leonardoGrade}\nJimena\t\t{jimenaAverage} {jimenaGrade}\nLiliana\t\t{lilianaAverage} {lilianaGrade}\n Javier\t\t{javierAverage} {javierGrade}");

/*
Output:

Student         Grade
Leonardo        94.6 A
Jimena          83.6 B
Liliana         83.4 B
 Javier         95.4 A
*/
