# 🎓 Student Management Console App

Bu loyiha **C# Console Application** bo‘lib, talabalarni boshqarish (qo‘shish, ro‘yxatini ko‘rish, sonini aniqlash) uchun mo‘ljallangan. Loyiha **Clean Architecture** ga yaqin yondashuv asosida tuzilgan va OOP tamoyillariga amal qiladi.

---

## 📌 Loyihaning asosiy imkoniyatlari

* 🔐 Parol orqali tizimga kirish (3 martagacha urinish)
* ➕ Yangi talaba qo‘shish
* 📋 Talabalar ro‘yxatini ko‘rish
* 📊 Qabul qilingan talabalar sonini ko‘rish
* 🚪 Dasturni davom ettirish yoki chiqish imkoniyati

---

## 🧱 Arxitektura tuzilmasi

Loyiha 4 ta asosiy qatlamdan iborat:

### 1️⃣ Domain Layer

**Vazifasi:** Ma’lumot modelini saqlash

📂 `Manaegment7.Domain.Models`

```csharp
public class Student
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
```

---

### 2️⃣ Infrastructure Layer

**Vazifasi:** Ma’lumotlarni xotirada saqlash (array orqali)

📂 `Managament7.Infrastructure.Data`

```csharp
public class DbContext
{
    public Student[] students { get; set; }
    public int studentCount { get; set; }

    public DbContext()
    {
        students = new Student[12];
        studentCount = 0;
    }
}
```

---

### 3️⃣ Application Layer

**Vazifasi:** Biznes mantiq (logic)

📂 `Management7.Application.Service`

Asosiy metodlar:

* `AddStudent()` — yangi talaba qo‘shadi
* `GetAllStudents()` — talabalar ro‘yxatini chiqaradi
* `GetStudentCount()` — talabalar sonini qaytaradi

---

### 4️⃣ Client Layer (UI)

**Vazifasi:** Foydalanuvchi bilan muloqot (Console)

📂 `Management7.Client`

Bu yerda:

* Parol tekshiriladi
* Menu chiqariladi
* Foydalanuvchi tanlovlariga qarab servislar chaqiriladi

---

## ▶️ Dasturni ishga tushirish

1. Visual Studio’da loyihani oching
2. `Program.cs` faylini ishga tushiring
3. Parol kiriting:

   ```
   1111
   ```
4. Menyudan kerakli bo‘limni tanlang

---

## 🧪 Namunaviy ishlash ketma-ketligi

```
Assalomu alaykum xurmatli o'qituvchi!

Tizimga kirish uchun parolni kiriting: 1111

Xush kelibsiz, Elbek!

1) Yangi talaba qo'shish
2) Talabalar ro'yxati
3) Qabullar soni
```

---

## ⚠️ Cheklovlar

* Maksimal talabalar soni: **12 ta**
* Ma’lumotlar faqat dastur ishlayotgan vaqtida saqlanadi (RAM)

---

## 🚀 Kelajakdagi rivojlantirish rejalar

* [ ] `List<Student>` ga o‘tish
* [ ] Talabalarni faylga (JSON) saqlash
* [ ] ID formatini `AA1234` ko‘rinishiga o‘tkazish
* [ ] Dependency Injection qo‘llash

---

## 👨‍💻 Muallif

* **Ism:** Elbek
* **Til:** C# (.NET)
* **Loyiha turi:** O‘quv / Amaliy

---

## 📄 Litsenziya

Ushbu loyiha o‘quv maqsadlarida yaratilgan va erkin foydalanish uchun ochiq.

---

⭐ Agar loyiha sizga foydali bo‘lsa, GitHub’da **star** bosishni unutmang!
