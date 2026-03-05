using System;
using System.Collections.Generic;
using System.Text;

struct Score
{
    public string Name;
    public int Kor;
    public int Eng;
    public int Total;
    public int Average;


    // 전부 매개변수로 받을 필요는 없음
    public Score(string name, int kor, int eng)
    {
        Name = name;
        Kor = kor;
        Eng = eng;
        Total = kor + eng;
        Average = Total / 2;
    }
}

struct Student
{
    public int Num;
    public string Name;
    public Score Scores;
}