using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNubeDePalabras
{
    [TestClass]
    public class TestEstudiante
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        /// <summary>
        /// Tests para verificar nombre.
        /// </summary>
        [TestMethod]
        
        public void TestVerificarNombre()
        {
            // Arranque
            String Nombre = "Lucas";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarNombre(Nombre);

            //Assert
            Assert.AreEqual(true, respues);
        }

        [TestMethod]
        [DataSource("System.Data.OleDB",
         @"Provider=Microsoft.ACE.OLEDB.12.0;
         Data Source=E:\2020-II\Construccion de software\nombres.xlsx;
         Extended Properties='Excel 12.0;
         HDR=yes';",
         "Nombres$",
         DataAccessMethod.Sequential)]
        public void TestVerificarNombre1()
        {
            // Arranque
            String Nombre = Convert.ToString(TestContext.DataRow["Nombres"]);
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarNombre(Nombre);

            //Assert
            Assert.AreEqual(true, respues);
        }

        /// <summary>
        /// Tests para verificar apellido.
        /// </summary>
        [TestMethod]
        public void TestVerificarApellido()
        {
            // Arranque
            String Apellido = "Rojas";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarApellido(Apellido);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests para verificar rpimera Respuesta.
        /// </summary>
        [TestMethod]
        public void TestVerificarIdea1()
        {
            // Arranque
            String Idea1 = "Java";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarIdea1(Idea1);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests para verificar segunda Pregunta.
        /// </summary>
        [TestMethod]
        public void TestVerificarIdea2()
        {
            // Arranque
            String Idea2 = "Phyton";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarIdea2(Idea2);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests para verificar tercera Pregunta.
        /// </summary>
        [TestMethod]
        public void TestVerificarIdea3()
        {
            // Arranque
            String Idea3 = "c#";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.Verificaridea3(Idea3);

            //Assert
            Assert.AreEqual(true, respues);
        }

    }
}
