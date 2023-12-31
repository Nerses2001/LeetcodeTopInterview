# LeetcodeTopInterview
# Algorithms for Merging, Removing Elements, and Majority Element

This repository contains algorithms implemented in C# to solve specific problems related to merging arrays, removing elements, and finding the majority element.

## Merge Sorted Arrays

### Problem Statement

You are given two integer arrays `nums1` and `nums2`, both sorted in non-decreasing order, and two integers `m` and `n`, representing the number of elements in `nums1` and `nums2` respectively.

Merge `nums1` and `nums2` into a single array sorted in non-decreasing order.

**LeetCode Problem Link:** [Merge Sorted Arrays - LeetCode](https://leetcode.com/studyplan/top-interview-150/)

### Examples

#### Example 1

Input: `nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3`
Output: `[1,2,2,3,5,6]`

#### Example 2

Input: `nums1 = [1], m = 1, nums2 = [], n = 0`
Output: `[1]`

#### Example 3

Input: `nums1 = [0], m = 0, nums2 = [1], n = 1`
Output: `[1]`

## Remove Element

### Problem Statement

Given an integer array `nums` and an integer `val`, remove all occurrences of `val` in `nums` in-place. The order of the elements may be changed. Then return the number of elements in `nums` which are not equal to `val`.

**LeetCode Problem Link:** [Remove Element - LeetCode](https://leetcode.com/studyplan/top-interview-150/)

### Examples

#### Example 1

Input: `nums = [3,2,2,3], val = 3`
Output: `2, nums = [2,2,_,_]`

#### Example 2

Input: `nums = [0,1,2,2,3,0,4,2], val = 2`
Output: `5, nums = [0,1,4,0,3,_,_,_]`

## Remove Duplicates

### Problem Statement

Given an integer array `nums` sorted in non-decreasing order, remove duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in `nums`.

**LeetCode Problem Link:** [Remove Duplicates - LeetCode](https://leetcode.com/studyplan/top-interview-150/)

### Examples

#### Example 1

Input: `nums = [1,1,1,2,2,3]`
Output: `5, nums = [1,1,2,2,3,_]`

#### Example 2

Input: `nums = [0,0,1,1,1,1,2,3,3]`
Output: `7, nums = [0,0,1,1,2,3,3,_,_]`

## Remove Duplicates (At Most Twice)

### Problem Statement

Given an integer array `nums` of size `n`, return the majority element, i.e., the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

**LeetCode Problem Link:** [Majority Element - LeetCode](https://leetcode.com/studyplan/top-interview-150/)

### Examples

#### Example 1

Input: `nums = [3,2,3]`
Output: `3`

#### Example 2

Input: `nums = [2,2,1,1,1,2,2]`
Output: `2`

## Rotate Array
### Problem Statement
Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

#### Example 1:

Input: `nums = [1,2,3,4,5,6,7], k = 3`
Output: `[5,6,7,1,2,3,4]`

#### Explanation:
rotate 1 steps to the right: `[7,1,2,3,4,5,6]`
rotate 2 steps to the right: `[6,7,1,2,3,4,5]`
rotate 3 steps to the right: `[5,6,7,1,2,3,4]`

#### Example 2:

Input: `nums = [-1,-100,3,99], k = 2`
Output: `[3,99,-1,-100]`
##### Explanation: 
rotate 1 steps to the right: `[99,-1,-100,3]`
rotate 2 steps to the right: `[3,99,-1,-100]`