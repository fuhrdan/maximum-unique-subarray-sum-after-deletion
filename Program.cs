//*****************************************************************************
//** 3487. Maximum Unique Subarray Sum After Deletion               leetcode **
//*****************************************************************************

int maxSum(int* nums, int numsSize) {
    int hashbrown[201] = {0};
    int coffee[101] = {0};
    int retnum = 0;
    int altnum = -100;
    int alternator = 0;
    int zero = 0;
    for(int i = 0; i < numsSize; i++)
    {
        if(nums[i] > 0) hashbrown[nums[i]]++;
        if(nums[i] < 0) coffee[nums[i]*-1]++;
        if(nums[i] == 0) zero = 1;
    }
    for(int j = 0; j < 101; j++)
    {
        if(hashbrown[j] > 0) 
        {
            retnum = retnum + j;
            alternator = 1;
        }
        if((coffee[j] > 0)&&((j*-1) > altnum)) altnum = (j * -1);
    }
    if(alternator == 1) return retnum;
    if(zero == 1) return 0;
    return altnum;

}