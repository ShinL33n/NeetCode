# Contains Duplicate

Easy Topics Company Tags Hints

Given an integer array `nums`, return `true` if any value appears **more than once** in the array, otherwise return `false`.

**Example 1:**

    Input: nums = [1, 2, 3, 3]

    Output: true

**Example 2:**

    Input: nums = [1, 2, 3, 4]

    Output: false

**Constraints:**

- `0 <= nums.length <= 10^5`
- `-10^9 <= nums[i] <= 10^9`

Topics

[Array](/practice/problem-list/array) [Hash Table](/practice/problem-list/hash-table) [Sorting](/practice/problem-list/sorting)

Recommended Time & Space Complexity

You should aim for a solution with `O(n)` time and `O(n)` space, where `n` is the size of the input array.

#### Hint 1

A brute force solution would be to check every element against every other element in the array. This would be an `O(n^2)` solution. Can you think of a better way?

#### Hint 2

Is there a way to check if an element is a duplicate without comparing it to every other element? Maybe there's a data structure that is useful here.

#### Hint 3

We can use a hash data structure like a hash set or hash map to store elements we've already seen. This will allow us to check if an element is a duplicate in constant time.

Company Tags

[TCS11](https://neetcode.io/practice/company/TCS) [Google7](https://neetcode.io/practice/company/Google) [Amazon5](https://neetcode.io/practice/company/Amazon) [Accenture4](https://neetcode.io/practice/company/Accenture) [IBM4](https://neetcode.io/practice/company/IBM) [Meta4](https://neetcode.io/practice/company/Meta) [Netflix4](https://neetcode.io/practice/company/Netflix) [Apple3](https://neetcode.io/practice/company/Apple) [Capgemini3](https://neetcode.io/practice/company/Capgemini) [Microsoft3](https://neetcode.io/practice/company/Microsoft) [Oracle3](https://neetcode.io/practice/company/Oracle) [Yahoo3](https://neetcode.io/practice/company/Yahoo) [Zoho3](https://neetcode.io/practice/company/Zoho) [Bloomberg2](https://neetcode.io/practice/company/Bloomberg) [Infosys2](https://neetcode.io/practice/company/Infosys)

Seen this question in a real interview?

Yes No

Acceptance Rate72.6%
