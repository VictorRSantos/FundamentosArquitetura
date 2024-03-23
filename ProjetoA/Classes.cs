using System.Runtime.CompilerServices;

// [assembly: InternalsVisibleTo("ProjetoB")]
// Extendendo a visibilidade do ProjetoA para o ProjetoB
namespace ProjetoA
{
    #region Classes
    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada { }
    class Privada { }
    internal class Interna { }
    abstract class Abstrata { }

    #endregion

    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }
       
    //class TesteSelada : Selada { }


    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {          

           TestePublico();
           TesteInternal();
           TesteProtegido();
           TesteProtegidoInterno();
           TestePrivadoProtegido();
           //TestePrivado();
        }
    }

    #endregion
}


/************************************************************/
// public:

// Access is not restricted 
/************************************************************/
// internal:

// Access is limited to the containing class or type
// derived from the containing class 
/************************************************************/
// protected internal:

// Access is limited to the current assembly or type
// derived from the containing class
/************************************************************/
// private:

// Access is limited to the containing type  
/************************************************************/
// private protected:

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since c# 7.2
/************************************************************/