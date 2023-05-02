using CrmUygulamasi.Entites.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Employees")]
public class Employee : EntityBase
{
    [DisplayName("İşe Giriş Tarihi")]
    public DateTime? StartDateofWork { get; set; }

    [DisplayName("Adı Soyadı")]
    [Required(ErrorMessage ="Adı Soyadı alanını boş geçemezsiniz..")]
    public string NameSurname { get; set; }


    [DisplayName("Kimlik No")]
    public string? CitizenNumber { get; set; }


    [DisplayName("Email")]
    [Required(ErrorMessage = "Email alanını boş geçemezsiniz..")]
    public string Email { get; set; }

    [DisplayName("Şifre")]
    [Required(ErrorMessage = "Şifre alanını boş geçemezsiniz..")]
    public string Password { get; set; }


    [DisplayName("Telefon")]
    public string? Phone { get; set; }


    [DisplayName("Durumu")]
    public bool State { get; set; }


    [DisplayName("Yetki")]
    public string Role { get; set; }

}
