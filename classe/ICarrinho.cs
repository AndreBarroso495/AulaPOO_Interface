namespace AulaPOO_Interface.classe
{
    public interface ICarrinho
    {
         //Criamos uma espécie de "contrato" para deixar obrigatória a implementação de todos os métodos e estruturas que herdarem dessa interface

         void Listar();

         void Cadastrar( Produto produto );

         void Alterar( int _codigo, Produto produto );

         void Deletar( Produto produto );
    }
}