using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos.Color
{
    public class AddColorDto
    {
        [Required(ErrorMessage ="Boş bırakılamaz...")]
        [MinLength(2,ErrorMessage ="En az 2 karakter giriniz...")]
        public string Name { get; set; }
        public string HexCode { get; set; }
    }
}
