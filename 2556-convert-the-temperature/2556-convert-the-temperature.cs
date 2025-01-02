public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double farenheit = celsius * 1.80 + 32.00;
        double kelvin = celsius + 273.15;
        double[] ans = new double[2];

        ans[0] = kelvin;
        ans[1] = farenheit;
        return ans;
    }
}