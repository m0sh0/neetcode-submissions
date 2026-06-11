class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
            hash_set = set()
            for num in nums:
                if not hash_set.__contains__(num):
                    hash_set.add(num)
                else:
                    return True
            
            return False