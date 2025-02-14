public class ProductOfNumbers {
    public static List<int> nums;

    public ProductOfNumbers() {
        nums = new List<int>();
        
    }
    
    public void Add(int num) {
        nums.Add(num);
    }
    
    public int GetProduct(int k) {
        int sum = nums[nums.Count - 1];
        for(int i = 1; i < k; i++)
        {
            sum *= nums[nums.Count - 1 - i];
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