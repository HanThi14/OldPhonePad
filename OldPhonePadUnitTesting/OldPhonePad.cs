using Microsoft.VisualStudio.TestPlatform.TestHost;
using OldPhonePad;
using System;
using Xunit;

namespace OldPhonePadUnitTesting
{
    public class OldPhonePad
    {
        [Fact]
        public void BasicTesting()
        {
            if (HandlingOldPhonePad.OldPhonePad("33#") != "A")
            {
                Assert.False(false);
                throw new Exception("33# failed");
            }
            else if(HandlingOldPhonePad.OldPhonePad("227*#") != "B")
            {
                Assert.False(false);
                throw new Exception("227*# failed");
            }
            else if(HandlingOldPhonePad.OldPhonePad("4433555 555666#") != "HELLO")
            {
                Assert.False(false);
                throw new Exception("4433555 555666# failed");
            }
            else if(HandlingOldPhonePad.OldPhonePad("8 88777444666*664#") != "TURING")
            {
                Assert.False(false);
                throw new Exception("8 88777444666*664# failed");
            }
            else
            {
                Assert.True(true);
            }           
        }

        [Fact]
        public void MultiplePressTesting()
        {
            if (HandlingOldPhonePad.OldPhonePad("2#") != "A")
            {
                Assert.False(false);
                throw new Exception("Single press is failed");
            }
            else if (HandlingOldPhonePad.OldPhonePad("22#") != "B")
            {
                Assert.False(false);
                throw new Exception("Double press is failed");
            }
            else if (HandlingOldPhonePad.OldPhonePad("222#") != "C")
            {
                Assert.False(false);
                throw new Exception("Triple press is failed");
            }
            else if (HandlingOldPhonePad.OldPhonePad("2222#") != "A")
            {
                Assert.False(false);
                throw new Exception("Wraps back to 'A' is failed");
            }
            else
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void BackspaceTesting()
        {
            if (HandlingOldPhonePad.OldPhonePad("2*#") != "")
            {
                Assert.False(false);
                throw new Exception("Single press and backspace is failed");
            }
            if (HandlingOldPhonePad.OldPhonePad("22*#") != "")
            {
                Assert.False(false);
                throw new Exception("Double press and backspace is failed");
            }
            else if (HandlingOldPhonePad.OldPhonePad("22*222#") != "C")
            {
                Assert.False(false);
                throw new Exception("Backspace and continous press is failed");
            }           
            else
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void InvalidInputTesting()
        {
            if (HandlingOldPhonePad.OldPhonePad("22") != "Invalid input. Please end the input with '#'.")
            {
                Assert.False(false);
                throw new Exception("Invalid input without # is failed");
            }
            else if (HandlingOldPhonePad.OldPhonePad("#") != "")
            {
                Assert.False(false);
                throw new Exception("Empty input is failed");
            }
            else if(HandlingOldPhonePad.OldPhonePad("*#") != "")
            {
                Assert.False(false);
                throw new Exception("Only backspace and empty input is failed");
            }
            else
            {
                Assert.True(true);
            }
        }

    }
}