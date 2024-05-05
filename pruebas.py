import unittest

def mcd(a, b):
    while b != 0:
        a, b = b, a % b
    return a

def mcd_cuatro_numeros(num1, num2, num3, num4):
    mcd_1 = mcd(num1, num2)
    mcd_2 = mcd(num3, num4)
    return mcd(mcd_1, mcd_2)

class TestMCD(unittest.TestCase):
    def test_mcd_cuatro_numeros(self):
        self.assertEqual(mcd_cuatro_numeros(12, 18, 24, 36), 6)
        self.assertEqual(mcd_cuatro_numeros(8, 16, 32, 64), 8)
        self.assertEqual(mcd_cuatro_numeros(5, 10, 15, 20), 5)

if __name__ == '__main__':
    unittest.main()