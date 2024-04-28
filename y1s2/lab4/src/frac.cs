namespace lab4_frac {
	public struct MyFrac {
		public long nominator, denominator;

		public MyFrac(long nom, long denom) {
			long g = MyFrac.gcd(nom, denom);

			nominator = nom / g;
			denominator = denom / g;
			
			if (denominator < 0) {
				nominator = -nominator;
				denominator = -denominator;
			}
		}

		private static long gcd(long nom, long denom) {
			long gcd = 0;
			long a = Math.Abs(nom);
			long b = Math.Abs(denom);

			while (b != 0) {
				gcd = b;
				b = a % b;
				a = gcd;
			}

			return gcd;
		}

		public override readonly string ToString() {
			return $"{nominator}/{denominator}";
		}
		
		public static string ToStringWithIntPart(MyFrac f) {
			string sign = (f.nominator * f.denominator < 0) ? "-" : "";
			long before_p = f.nominator / f.denominator;
			long after_p = f.nominator % f.denominator;

			if (before_p == 0)
				return $"{sign}{after_p}/{f.denominator}";
			else if (after_p == 0)
				return $"{sign}{before_p}";
			else
				return $"{sign}{before_p} + {Math.Abs(after_p)}/{f.denominator}";
		}

		public static double DoubleValue(MyFrac f) {
			return (double)f.nominator / f.denominator;
		}

		public static MyFrac Plus(MyFrac f1, MyFrac f2) {
			long nom = f1.nominator * f2.denominator + f2.nominator * f1.denominator;
			long denom = f1.denominator * f2.denominator;
			return new MyFrac(nom, denom);
		}

		public static MyFrac Minus(MyFrac f1, MyFrac f2) {
			long nom = f1.nominator * f2.denominator - f2.nominator * f1.denominator;
			long denom = f1.denominator * f2.denominator;
			return new MyFrac(nom, denom);
		}

		public static MyFrac Multiply(MyFrac f1, MyFrac f2) {
			long nom = f1.nominator * f2.nominator;
			long denom = f1.denominator * f2.denominator;
			return new MyFrac(nom, denom);
		}

		public static MyFrac Divide(MyFrac f1, MyFrac f2) {
			long nom = f1.nominator * f2.denominator;
			long denom = f1.denominator * f2.nominator;
			return new MyFrac(nom, denom);
		}

		public static MyFrac CalcExpr1(int n) {
			MyFrac f3 = new(0, 1);
			for (int i = 1; i <= n; i++)
				f3 = Plus(f3, new MyFrac(1, i * (i + 1)));
			return f3;
		}

		public static MyFrac CalcExpr2(int n) {
			MyFrac f3 = new(1, 1);
			for (int i = 2; i <= n; i++)
				f3 = Multiply(f3, new MyFrac(i * i - 1, i * i));
			return f3;
		}
	}	
}
