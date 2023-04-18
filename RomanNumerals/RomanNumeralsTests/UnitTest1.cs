namespace RomanNumeralsTests
{
    public class ConverTest
    {
        // 1 --> I
        [Fact]
        public void Convert1toI()
        {
            // 1 --> I
            int input = 1;
            var expectedOutput = "I";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 2 --> II
        [Fact]
        public void Convert2toII()
        {
            // 1 --> I
            int input = 2;
            var expectedOutput = "II";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 3 --> III
        [Fact]
        public void Convert3()
        {
            // 1 --> I
            int input = 3;
            var expectedOutput = "III";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 4 --> IV
        [Fact]
        public void Convert4()
        {
            // 1 --> I
            int input = 4;
            var expectedOutput = "IV";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 5 --> V
        [Fact]
        public void Convert5()
        {
            // 1 --> I
            int input = 5;
            var expectedOutput = "V";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 6 --> VI
        [Fact]
        public void Convert6()
        {
            // 1 --> I
            int input = 6;
            var expectedOutput = "VI";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 7 --> VII
        [Fact]
        public void Convert7()
        {
            // 1 --> I
            int input = 7;
            var expectedOutput = "VII";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 8 --> VIII
        [Fact]
        public void Convert8()
        {
            // 1 --> I
            int input = 8;
            var expectedOutput = "VIII";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 9 --> IX
        [Fact]
        public void Convert9()
        {
            // 1 --> I
            int input = 9;
            var expectedOutput = "IX";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 10 --> X
        [Fact]
        public void Convert10()
        {
            // 1 --> I
            int input = 10;
            var expectedOutput = "X";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 11
        [Fact]
        public void Convert11()
        {
            // 1 --> I
            int input = 11;
            var expectedOutput = "XI";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 12
        [Fact]
        public void Convert12()
        {
            // 1 --> I
            int input = 12;
            var expectedOutput = "XII";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
        // 12
        [Fact]
        public void Convert13()
        {
            // 1 --> I
            int input = 13;
            var expectedOutput = "XIII";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
        // 12
        [Fact]
        public void Convert14()
        {
            // 1 --> I
            int input = 14;
            var expectedOutput = "XIV";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
        // 12
        [Fact]
        public void Convert15()
        {
            // 1 --> I
            int input = 15;
            var expectedOutput = "XV";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
        // 12
        [Fact]
        public void Convert16()
        {
            // 1 --> I
            int input = 16;
            var expectedOutput = "XVI";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
        // 12
        [Fact]
        public void Convert17()
        {
            // 1 --> I
            int input = 17;
            var expectedOutput = "XVII";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
        // 12
        [Fact]
        public void Convert18()
        {
            // 1 --> I
            int input = 18;
            var expectedOutput = "XVIII";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
        // 12
        [Fact]
        public void Convert19()
        {
            // 1 --> I
            int input = 19;
            var expectedOutput = "XIX";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 20
        [Fact]
        public void Convert20()
        {
            // 1 --> I
            int input = 20;
            var expectedOutput = "XX";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }


        // 21
        [Fact]
        public void Convert21()
        {
            // 1 --> I
            int input = 21;
            var expectedOutput = "XXI";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }


        // 30
        [Fact]
        public void Convert30()
        {
            // 1 --> I
            int input = 30;
            var expectedOutput = "XXX";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }

        // 40
        [Fact]
        public void Convert40()
        {
            // 1 --> I
            int input = 40;
            var expectedOutput = "XL";

            var converter = new RomanConverter();
            var result = converter.ConvertNumbertoRoman(input);

            Assert.Equal(expectedOutput, result);
        }
    }
}