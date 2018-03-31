namespace MiniSPA.EscolaVirtual.Registros.Interfaces
{
    public interface IRegistroFactory
    {
        Registro BuildRegistration();

        string ObterCursosSerializado();

        string ObterEstudantesSerializado();
    }
}