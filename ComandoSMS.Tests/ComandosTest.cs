using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ComandoSMS.Tests
{
    [TestClass]
    public class ComandosTest
    {
        Teclado teclado = new Teclado();

        [TestMethod]
        public void DeveRetornar7773322244()
        {
            Assert.AreEqual("7773322244", teclado.MostrarComando("RECH"));
        }

        [TestMethod]
        public void DeveRetornar8884442228666777()
        {
            Assert.AreEqual("8884442228666777", teclado.MostrarComando("VICTOR"));
        }

        [TestMethod]
        public void DeveRetornar3344482055524442()
        {
            Assert.AreEqual("3344482055524442", teclado.MostrarComando("EITA LAIA"));
        }

        [TestMethod]
        public void DeveRetornar2_222_23_33644420366607_77766647772623666777()
        {
            Assert.AreEqual("2_222_23_33644420366607_77766647772623666777", teclado.MostrarComando("ACADEMIA DO PROGRAMADOR"));
        }

        [TestMethod]
        public void DeveRetornar77773367_7773302_222337777_777766606660366656667889999_9999555337777()
        {
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", teclado.MostrarComando("SEMPRE ACESSO O DOJOPUZZLES"));
        }

        [TestMethod]
        public void DeveRetornar2_22_2223_33_3334_44_4445_55_5556_66_6667_77_777_77778_88_8889_99_999_9999()
        {
            Assert.AreEqual("2_22_2223_33_3334_44_4445_55_5556_66_6667_77_777_77778_88_8889_99_999_9999", teclado.MostrarComando("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
        }

        [TestMethod]
        public void DeveRetornar0_0_0()
        {
            Assert.AreEqual("0_0_0", teclado.MostrarComando("   "));
        }

        [TestMethod]
        public void DeveRetornarMensagemInvalida()
        {
            Assert.AreEqual("Mensagem deve ter no máximo 255 caracteres", teclado.MostrarComando("eKHmiiTF1WMiR3Kh21JcF6q0YcReDHafQ5E1iR8Omp" +
                "Mz2L9hH1lNS2s9x61sN0GzXyCUHCxUC0LbAposf7O3rnwDlqHbIxyPGuqu6sNK6CqpXyOT2OYT6yaerQUjUZAJ8gEwpGxVlg4chk0PcApgEyygadSbqYivYVo08" +
                "BQ3499Qstu9d2xSU4gm123NJ6LoDwYbDnLnEVBTHcT4JsHyCK7W2cbxkOQTZXvU54jbr1U69ppySyf8MU7do3985hyE4FOIfh2F39fn318fnRJRg28wiLNcifK"));
        }
    }
}
