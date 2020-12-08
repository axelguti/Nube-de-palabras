using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNubeDePalabras
{
    [TestClass]
    public class TestPantallaProfesor
    {
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
