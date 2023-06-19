## Challange 01 reverse Array 


## Insert Shift array 

- ### WhiteBoard Title 
    
    - ![WhiteBoard Search Binary](./binarySearchWhiteBoard.jpg)

- ### Approach & Efficiency

    - What approach did you take? Why? What is the Big O space/time for this approach

        - i take an divide iteration approaach to loop through my first index to last index 
        and check every time if the mid index of element is equal to the number i looking for 
        if it is not please go and check if the element of the mid index is bigger than the number i want to search if it is go and make the last = mid -1 
        and if the element of the mid index is less than the number go and make the first = mid + 1 and, keep iterate till the first become bigger than the last index 
        if the number i looking for is not found return -1
        - the Big O notation is for both space and time O(n).

- ### Solution

    - here are some screen shots for my code :


    - ![insert shift array](./output.jpg)

    - ![Code Source](./New%20Bitmap%20Image.jpg) 


- ### Strech Goal 
    - **Note** time is 20/6/2023 12:35AM

    - The question was What would you need to change if the array contained objects (sorted on a given property), and you were searching for certain property value? Write out the pseudocode.

        - as i understand the binary search it dosent matter what i deal with if it is an array and sorted by following the rules it will be easy

         ```bash
        define binarysearch (Object[] array, searchProperty)

        define first = 0
        deifne last = array.length-1
        while first less or equal  last
        define middle = first+last divide on 2
        define midlleproperty = array[middle].propertyname
        if middleproperty == searchproperty 
        return middle;
        else if middleproperty > searchproperty 
        let last = middle - 1

        else 
        let first = middle + 1
        
        else return -1
        ```
    - it should be like this or close to this one i don't know exactly but that what i expect 