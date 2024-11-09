using System.ComponentModel.DataAnnotations;

public class Cliente{
    public int ClienteId {get ; set;}
    
    [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do cliente não pode ter mais de 100 caracteres.")]
    public string? Nome{get ; set;}

    [Required(ErrorMessage ="O email do cliente é obrigatório.")]
    [StringLength(100, ErrorMessage ="O email do cliente não pode ter mais de 100 caracteres.")]
    public string? Email{get ; set;}

    [Required(ErrorMessage = "O número pra contato do cliente é obrigatório.")]
    [StringLength(11, ErrorMessage ="O número do cliente não pode ter mais de 11 caracteres.")]
    public string? Numero{get ; set;}

    [Required(ErrorMessage = "A data de nascimento do cliente é obrigatória.")]
    public DateOnly DataNascimento{get ; set;}
}