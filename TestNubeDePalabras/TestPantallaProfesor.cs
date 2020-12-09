using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNubeDePalabras
{
    [TestClass]
    public class TestPantallaProfesor
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        /// <summary>
        /// Tests para los datos de la pregunta.
        /// </summary>
        [TestMethod]
        public void Test_DatosPregunta()
        {
            //Arranque
            String Pregunta = "Como estas";
            Boolean respues;
            Nube_de_palabras.PantallaProfesor resp = new Nube_de_palabras.PantallaProfesor();

            //Act
            respues = resp.VerificarPregunta(Pregunta);

            //Assert
            Assert.AreEqual(true,respues);
        }
        /// <summary>
        /// Tests de pruebas controlada por datos.
        /// </summary>
        [TestMethod]
        [DataSource("System.Data.OleDB",
         @"Provider=Microsoft.ACE.OLEDB.12.0;
         Data Source=E:\2020-II\Construccion de software\nombres.xlsx;
         Extended Properties='Excel 12.0;
         HDR=yes';",
         "Preguntas$",
         DataAccessMethod.Sequential)]
        public void TestDatosPregunta()
        {
            //Arranque
            String Pregunta = Convert.ToString(TestContext.DataRow["Preguntas"]); ;
            Boolean respues;
            Nube_de_palabras.PantallaProfesor resp = new Nube_de_palabras.PantallaProfesor();

            //Act
            respues = resp.VerificarPregunta(Pregunta);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests para la cantidad de preguntas.
        /// </summary>
        [TestMethod]
        public void Test_DatosCantidadDePreguntas()
        {
            //Arranque
            int canti = 1;
            int respues;
            Nube_de_palabras.PantallaProfesor resp = new Nube_de_palabras.PantallaProfesor();

            //Act
            respues = (int)resp.dEntrada.Value;

            //Assert
            Assert.AreEqual(1, respues);
        }
    }
}
