
using System;


namespace Arrays
{
    internal class Program 
    {
        static void Main(string[] args)
        {
        #region Temel Dizi Örnekleri
             //2,4,6,8
             // sarı,kırmızı,mavi,turuncu,beyaz
            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı]

            // string[] colors=new string[4];

            // colors[0]="Kırmızı";
            // colors[1]="Sarı";
            // colors[2]="Yeşil";
            // colors[3]="Mavi";

            // Console.WriteLine(colors[3]);

            // int[] numbers = new int[10];

            // numbers[0]=50;
            // numbers[1]=75;
            // numbers[2]=42;
            // numbers[3]=45;
            // numbers[4]=56;
            // numbers[5]=78;
            // numbers[6]=60;
            // numbers[7]=19;
            // Console.WriteLine(numbers[6]); 

            // string[] cities = {"Prag", "Roma", "Atina"};

            // Console.WriteLine(cities[2]);
            
            #endregion
        #region Dizideki Tüm Elemanları Listeleme
        // string[] colors = {"Sarı","Yeşil", "Kırmızı","Yeşil"};

        // for(int i= 0; i < colors.Length; i++)
        // {
        //     Console.WriteLine(colors[i]);
        // }

        // int[] numbers = {4,85,96,74,215,635,488,520,746,2365,120};
        // for(int i=0; i< numbers.Length;i++)
        // {
        //     if(numbers[i] % 3 == 0)
        //     {
        //         Console.WriteLine(numbers[i]);
        //     }
        // }
        // Char da da sadece tek tırnak kullanılır.

        // int[] myarray = {47,85,95,41,25,635,789,86,100};

        // int maxNumber = myarray[0];
        // for(int i=0;i < myarray.Length; i++)
        // {
        //     if(myarray[i] > maxNumber)
        //     {
        //         maxNumber = myarray[i];
        //     }
        // } 
        // Console.WriteLine(maxNumber);

        // string[] persons = {"Ali", "Mustafa", "Mehmet","Ahmet","Cem" };
        // Console.WriteLine(persons.Length);

        #endregion
         #region Lenght, Short, Reverse
        //  string[] person = {"Ali", "Ayşe", "Fatma", "Ceylin"};
        //  Console.WriteLine(person.Lenght);
        // int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
        // Array.Sort(numbers);
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        //  }

        // }
         #endregion
        #region Dizi Metotlar
        // string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar" };
        // int index = Array.IndexOf(customers, "Ayşegül");
        // Console.WriteLine(index);

        //----------------------------- MİN-MAX
        // int[] numbers = {1,2,3,4,5,6,22,44,66};
        // Console.WriteLine("Min Sayı:"+ numbers.Min() + "Max Sayı"+ numbers.Max());

        #endregion
        #region Kullanıcıdan Değer Alma
    //     string[] cities = new string[5]; // Dizi boyutunu belirtin
    //     for (int i = 0; i < cities.Length; i++) // Buradaki 'Lenght' -> 'Length' olarak düzeltilmeli
    //     {
    // Console.WriteLine($"Lütfen {i + 1}. şehri yazınız:");
    // cities[i] = Console.ReadLine();
    // }
    //  Console.WriteLine();
    //  Console.WriteLine("-------------");
    //  for (int i = 0;i < cities.Length;i++)
    //  {
    //     Console.WriteLine(cities[i]);
    //  }
    // ------------------
    // int[] numbers = {10,20,30,40,50};
    // int sum = 0;

    // for (int i =0; i < numbers.Length; i++)
    // {
    //     sum += numbers[i];
    // }
    // Console.WriteLine(sum);
    // int[] numbers = {10,21,33,40,50};
    // Console.WriteLine("Çift Sayılar");
    // for (int i = 0; i < numbers.Length;i++ )
    // {
    //     if(numbers[i] % 2 ==0)
    //     {
    //         Console.WriteLine(numbers[i]);
    //     }
    // }
    // Console.WriteLine("Tek Sayılar");
    // for (int i = 0; i < numbers.Length;i++ )
    // {
    //     if(numbers[i] % 2 ==1)
    //     {
    //         Console.WriteLine(numbers[i]);
    //     }

        #endregion
        #region Foreach 

        // Foreach(1;2;3;4)

        // 1: Değişken Türü
        // 2: Değişken Adı
        // 3: In
        // 4: Liste, Koleksiyon, Dizi
        // string[] cities = {"Budapeşte", "Mersin", "Istanbul", "Antalya", "isparta", "Hatay"};

        // foreach(string city in cities)
        // {
        //     Console.WriteLine(city);
        // }
        // int[] numbers = {45, 90 , 400, 36};

        // foreach(int num in numbers)
        // {
        //     if(num%2==0)
        //     {
        //         Console.WriteLine(num);
        //     }
        // }
        // int[] numbers = {45, 90 , 400, 36};

        // int total =0;

        // foreach(int num in numbers)
        // {
        //     total += num;
        // }
        // Console.WriteLine(total);


        // LİSTELER Bir koleksiyon öğesidir.

        // List<int> numbers = new List<int>()
        // {
        //     1, 2, 3, 4, 5, 6, 7
        // };
        // foreach(int sayi in numbers)
        // {
        // Console.WriteLine(sayi);    
        // }

        // string word ="Merhaba";

        // foreach(char c in word)
        // {
        //     Console.WriteLine(c);
        // }

        #endregion
        #region Örnek Sınav Sistemi Uygulaması

//         Console.WriteLine("****** C# Sınav Uygulaması******");
//         Console.WriteLine();
//         Console.WriteLine();
//         Console.WriteLine("-------------------------");
//         Console.WriteLine("Sınıfınızda Kaç Öğrenci Var");
//         int studentCount =int.Parse(Console.ReadLine());
        
//         // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
//         string[] studentNames = new string[studentCount];
//         double[] studentExamAvg = new double[studentCount];

//         for(int i=0; i<studentCount;i++)
//         {
//             Console.Write($"{i+1}. öğrencinin ismini giriniz");
//             studentNames[i] =Console.ReadLine();
//             double totalExamResult=0;
//  // Her öğrenci için 3 sınav notu girişi 
//             for (int j =0;j < 3;j++)
//             {
//             Console.WriteLine($"{studentNames[i]} öğrencinin {j+1}. not girişini sağlayınız.");
//             double value =double.Parse(Console.ReadLine());
//             totalExamResult += value;       
//             }
//         studentExamAvg[i] = totalExamResult / 3;
//         }

//         //Sınav Ort
//         for(int i =0; i < studentCount; i++)
//         {
//             Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

//         if(studentExamAvg[i] >= 50)
//        {
//         Console.WriteLine($"{studentNames[i]} adlı öğrenci Ortalama Üstündedir.");
//        }
//        else{
//         Console.WriteLine($"{studentNames[i]} adlı öğrenci Ortalama Altındadır.");
//        }
       // öğrencilerin ort ve geçip kalma durumları
        #endregion
        #region  Void Metotlar 7.Ders  
        //()
        //Customer --> Listele, ekle, sil, güncelle 
        //Geriye Değer Döndürmeyen Metotlar
        // 

        // void CustomerList()
        // {
        // Console.WriteLine("Ali Yıldız");
        // Console.WriteLine("Ayşe Can");
        // Console.WriteLine("Hakan Yıldız");
        // }
        // CustomerList();
        
        
         #endregion 
         #region Geriye Değer Döndürmeyen String Parametreli Metotlar
         
        //  void WriteMethod(string custumerName)
        //  {
        //     Console.WriteLine(custumerName);

        //  }
        //  WriteMethod("Mehmet Yıldırım");

        // void CustomerCard(string name,string surName)
        // {
        //     Console.WriteLine("Müşteri" + name + ""+surName);
        // }

        // CustomerCard("Mehmet", "Yıldız");
        // CustomerCard("Ali", "Yıldız");
//Geriye Değer Döndürmeyen İNT Parametreli Metotlar

// void Sum(int number1, int number2, int number3)
// {
//     int result = number1 +number2 + number3;
//     Console.WriteLine(result);
// }    
//     Sum(4,5,6);
    #endregion
    #region Geriye Değer Döndüren Metotlar
    
    // string CustomerName()
    // {
    //     return " Buse Yıldız";
    // }
    // CustomerName();

    // string StudentCard()
    // {
    //     string name = "Ali";
    //     string surname ="Kaya";
    //     return name + " " + surname;
    //         }
    //         Console.WriteLine(StudentCard());

  //  Geriye Değer Döndüren parametreli Metotlar
      
      string CountryCard(string countryName, string capital, string flagColor)
      {
        string cardInfo=countryName + " "+capital+" "+ flagColor;
        return cardInfo;
      }
      string x,y,z;
      Console.Write("Ülke Adını Giriniz");
      x =Console.ReadLine();

      Console.Write("Başkenti Giriniz");
      y =Console.ReadLine();

      Console.Write("Bayrak Rengini Giriniz");
      z =Console.ReadLine();

     Console.WriteLine(CountryCard(x,y,z));

   #endregion
    
    }
}
}