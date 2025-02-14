public class ProductOfNumbers {
    public static List<int> nums;

    public ProductOfNumbers() {
        nums = new List<int>();
        
    }
    
    public void Add(int num) {
        nums.Add(num);
    }
    
    public int GetProduct(int k) {
        int lastIndex = nums.Count - 1;
        int sum = nums[lastIndex];
        for(int i = 1; i < k; i++)
        {
            sum *= nums[lastIndex - i];
        }
        return sum;
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */