using System;
using System.Threading;
using static System.Console;



// README.md를 읽고 코드를 작성하세요.

// 1-1
Point point = new Point();
point.X = 100;
point.Y = 200;
Console.WriteLine($"X: {point.X}, Y: {point.Y}");
WriteLine();

// 1-2
Product product = new Product();
product.Id = 1;
product.Title = "좋은 책";
product.Price = 10000;
WriteLine($"번호: {product.Id}\n상품명: {product.Title}\n가격: {product.Price}");

WriteLine();

// 1-3
BusinessCard bc = new BusinessCard();
bc.Name = "홍길동";
bc.Age = 21;
bc.Address = "서울시";
WriteLine($"{bc.Name}, {bc.Age}, {bc.Address}");

WriteLine();


// 2-1
Point p = new Point(100, 200);
WriteLine($"X: {p.X}, Y: {p.Y}");

WriteLine();

// 3-1
BusinessCard[] bcs = new BusinessCard[]
{
    new BusinessCard ("홍길동", 17),
    new BusinessCard ("백두산", 102),
    new BusinessCard ("임꺽정", 31)
};

foreach (BusinessCard bc1 in bcs)
{
    Console.WriteLine($"{bc1.Name}은(는) {bc1.Age}살입니다.");
}

WriteLine();

// 3-2
Score[] scores = new Score[3]
{
    new Score ("홍길동", 100, 90),
    new Score ("백두산", 100, 70),
    new Score ("임꺽정", 100, 50)
};

WriteLine("이름\t총점 평균");
foreach (Score score in scores)
{
    WriteLine($"{score.Name}\t{score.Total}  {score.Average}");
}

WriteLine();

// 4-1

//PrintWithParams 에 넘길 개별 매개변수
string Name = "홍길동";
int Age = 21;
PrintWithParams(Name, Age);

//PrintWithStruct 에 넘길 구조체 매개변수 생성
Member member = new Member();
member.Name = "백두산";
member.Age = 100;
PrintWithStruct(member);
void PrintWithParams(string name, int age)   // 개별 매개변수를 받는 함수
{
    WriteLine($"이름: {name}, 나이: {age}");
}

void PrintWithStruct(Member member)  // 구조체를 매개변수로 받는 함수
{
    WriteLine($"이름: {member.Name}, 나이: {member.Age}");
}

WriteLine();

// 5-1


