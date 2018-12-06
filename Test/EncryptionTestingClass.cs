using AAA.Helpers;
using NUnit.Framework;

namespace AAAEncryptionExample
{
    [TestFixture()]
    public class EncryptionTestingClass
    {
        [Test(Author ="Calvin Brown", Description ="Test to ensure plain string and encrypted are diff")]
        public void TestEncryption()
        {
            string stringToEncrypt  = "99fa50c4-54d3-47c3-afc7-ec1a050a4fd4";

            string encryptedString  = CommonFunctions.Encrypt(stringToEncrypt, "123456789");

            // if the strings aren't the same, the test passes
            Assert.True(stringToEncrypt != encryptedString);
        }
    }
}
