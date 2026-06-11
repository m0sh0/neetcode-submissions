from collections import Counter

class Solution:
     def isAnagram(self, s: str, t: str) -> bool:
        dict_s = Counter(s)
        dict_t = Counter(t)
        
        if dict_s == dict_t:
            return True
        else:
            return False

        