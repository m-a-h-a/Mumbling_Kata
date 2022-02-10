using Mumble;
using NUnit.Framework;

namespace Muble_Tests
{
    public class Tests
    {
        MumbleLetters _mumble;

        [SetUp]
        public void Setup()
        {
            _mumble = new MumbleLetters();
        }

        [TestCase("")]
        public void GivenEmptyString_HandleNull(string lettersProvided)
        {
            //arrange


            //act
            string letters = _mumble.mumble_letters(lettersProvided);

            //assert
            Assert.IsEmpty(letters);
        }

        [TestCase("a")]
        public void Given_a_ReturnA(string lettersProvided)
        {
            //arrange


            //act
            string letters = _mumble.mumble_letters(lettersProvided);

            //assert
            Assert.AreEqual("A", letters);
        }

        [TestCase("abC")]
        public void Given_abC_ReturnA_Bb_Ccc(string lettersProvided)
        {
            //arrange


            //act
            string letters = _mumble.mumble_letters(lettersProvided);

            //assert
            Assert.AreEqual("A-Bb-Ccc", letters);
        }

        [TestCase("aBCd")]
        public void Given_aBCd_ReturnA_Bb_Ccc_Dddd(string lettersProvided)
        {
            //arrange


            //act
            string letters = _mumble.mumble_letters(lettersProvided);

            //assert
            Assert.AreEqual("A-Bb-Ccc-Dddd", letters);
        }

        [TestCase("QWERTY")]
        public void Given_QWERTY_ReturnQ_Ww_Eee_Rrrr_Ttttt_Yyyyyy(string lettersProvided)
        {
            //arrange


            //act
            string letters = _mumble.mumble_letters(lettersProvided);

            //assert
            Assert.AreEqual("Q-Ww-Eee-Rrrr-Ttttt-Yyyyyy", letters);
        }
    }
}