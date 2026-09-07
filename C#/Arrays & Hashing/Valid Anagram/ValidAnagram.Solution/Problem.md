# Valid Anagram

Easy Topics Company Tags Hints

Given two strings `s` and `t`, return `true` if the two strings are anagrams of each other, otherwise return `false`.

Two strings are **anagrams** if they contain the same characters, with each character appearing the same number of times, regardless of order.

**Example 1:**

```java
Input: s = "racecar", t = "carrace"

Output: true
```

**Example 2:**

```java
Input: s = "jar", t = "jam"

Output: false
```

**Example 3:**

```java
Input: s = "x", t = "x"

Output: true
```

**Constraints:**

- `1 <= s.length, t.length <= 5 * 10^4`
- `s` and `t` consist of lowercase English letters.

Topics

[Hash Table](/practice/problem-list/hash-table) [String](/practice/problem-list/string) [Sorting](/practice/problem-list/sorting)

Recommended Time &amp; Space Complexity

You should aim for a solution with `O(n + m)` time and `O(1)` space, where `n` is the length of the string `s` and `m` is the length of the string `t`.

Hint 1

A brute force solution would be to sort the given strings and check for their equality. This would be an `O(nlogn + mlogm)` solution. Though this solution is acceptable, can you think of a better way without sorting the given strings?

Hint 2

By the definition of the anagram, we can rearrange the characters. Does the order of characters matter in both the strings? Then what matters?

Hint 3

We can just consider maintaining the frequency of each character. We can do this by having two separate hash tables for the two strings. Then, we can check whether the frequency of each character in string `s` is equal to that in string `t` and vice versa.

Company Tags

Please upgrade to [NeetCode Pro](https://neetcode.io/pro) to view company tags.

Seen this question in a real interview?

Yes No

Acceptance Rate65.6%
