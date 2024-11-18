namespace InvestHelper.Domain.Entity
{
    using System;

    public class Entidade : IEquatable<Entidade>
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string UsuarioCriacao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public bool Equals(Entidade other)
        {
            if (other is null) return false;
            return Id == other.Id;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Entidade);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return $"Entidade [Id={Id}, DataCriacao={DataCriacao}, DataAtualizacao={DataAtualizacao}, UsuarioCriacao={UsuarioCriacao}, UsuarioAtualizacao={UsuarioAtualizacao}]";
        }
        public static bool operator ==(Entidade left, Entidade right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }
        public static bool operator !=(Entidade left, Entidade right)
        {
            return !(left == right);
        }
    }
}
