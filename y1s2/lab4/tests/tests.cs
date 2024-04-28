using Xunit;
using lab4_frac;

namespace lab4_tests {
	public partial class Tests {
		[Fact]
		public void MyFrac_StringOverride_ReturnsString() {
			MyFrac f = new(12, -34);

			string result = f.ToString();

			Assert.Equal("-6/17", result);
		}

		[Fact]
		public void MyFrac_Plus_ReturnsFrac() {
			MyFrac f1 = new(1, 2);
			MyFrac f2 = new(1, 3);

			MyFrac result = MyFrac.Plus(f1, f2);

			Assert.Equal("5/6", result.ToString());
		}

		[Fact]
		public void MyFrac_Minus_ReturnsFrac() {
			MyFrac f1 = new(7, 9);
			MyFrac f2 = new(2, 5);

			MyFrac result = MyFrac.Minus(f1, f2);

			Assert.Equal("17/45", result.ToString());
		}

		[Fact]
		public void MyFrac_Minus_ReturnsFrac2() {
			MyFrac f1 = new(7, 9);
			MyFrac f2 = new(2, -5);

			MyFrac result = MyFrac.Minus(f1, f2);

			Assert.Equal("53/45", result.ToString());
		}

		[Fact]
		public void MyFrac_Multiply_ReturnsFrac() {
			MyFrac f1 = new(4, 7);
			MyFrac f2 = new(1, 3);

			MyFrac result = MyFrac.Multiply(f1, f2);
			
			Assert.Equal("4/21", result.ToString());
		}
		
		[Fact]
		public void MyFrac_Divide_ReturnsFrac() {
			MyFrac f1 = new(4, 7);
			MyFrac f2 = new(1, 3);

			MyFrac result = MyFrac.Divide(f1, f2);
			
			Assert.Equal("12/7", result.ToString());
		}

		[Fact]
		public void MyFrac_DoubleValue_ReturnsDouble() {
			MyFrac f = new(9, 8);

			double result = MyFrac.DoubleValue(f);
			
			Assert.Equal(1.125, result);
		}
		
		[Fact]
		public void MyFrac_ToStringWithIntPart_ReturnsString() {
			MyFrac f = new(5, 2);

			string result = MyFrac.ToStringWithIntPart(f);

			Assert.Equal("2 + 1/2", result);
		}
		
		[Fact]
		public void MyFrac_ToStringWithIntPart_ReturnsString2() {
			MyFrac f = new(1, 2);

			string result = MyFrac.ToStringWithIntPart(f);

			Assert.Equal("1/2", result);
		}
		
		[Fact]
		public void MyFrac_ToStringWithIntPart_ReturnsString3() {
			MyFrac f = new(16, 4);

			string result = MyFrac.ToStringWithIntPart(f);

			Assert.Equal("4", result);
		}
		
		[Fact] 
		public void MyFrac_CalcExpr1_ReturnsFrac() {
			MyFrac result = MyFrac.CalcExpr1(33);

			Assert.Equal("33/34", result.ToString());
		}
		
		[Fact]
		public void MyFrac_CalcExpr2_ReturnsFrac() {
			MyFrac result = MyFrac.CalcExpr2(44);

			Assert.Equal("45/88", result.ToString());
		}
	}
}
