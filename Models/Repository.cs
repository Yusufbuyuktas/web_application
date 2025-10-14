using System.Collections.Generic;

public static class Repository
{
    public static readonly List<Student> Students = new List<Student>();

    static Repository()
    {
        Students.Add(new Student
        {
            StudentID = 1,
            Name = "Yusuf",
            Surname = "Büyüktaş",
            Signed = false,
            SignedAt = DateTime.MinValue

        });
        Students.Add(new Student { StudentID = 2, Name = "Mehmet", Surname = "Yilmaz", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 3, Name = "Ahmet", Surname = "Demir", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 4, Name = "Fatma", Surname = "Gunes", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 5, Name = "Mustafa", Surname = "Celik", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 6, Name = "Zeynep", Surname = "Tekin", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 7, Name = "Emre", Surname = "Sahin", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 8, Name = "Elif", Surname = "Yildirim", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 9, Name = "Osman", Surname = "Ozturk", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 10, Name = "Selin", Surname = "Aydin", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 11, Name = "Can", Surname = "Kara", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 12, Name = "Melisa", Surname = "Arslan", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 13, Name = "Burak", Surname = "Kurt", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 14, Name = "Gizem", Surname = "Polat", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 15, Name = "Deniz", Surname = "Aksoy", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 16, Name = "Cem", Surname = "Erdogan", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 17, Name = "Sena", Surname = "Koc", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 18, Name = "Umut", Surname = "Saygi", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 19, Name = "Gokce", Surname = "Uysal", Signed = false, SignedAt = DateTime.MinValue });
        Students.Add(new Student { StudentID = 20, Name = "Ibrahim", Surname = "Toprak", Signed = false, SignedAt = DateTime.MinValue });




    }
}