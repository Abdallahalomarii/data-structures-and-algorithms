# Stack & Queue Challenge 10 
## 

- ### Approach & Efficiency

    - What approach did you take? Why? What is the Big O space/time for this approach

        - I take approch on the stack of adding a node to the first of the stack and by assign the top to first node in the stack
        each time i add a node, and for the pop method i take an approch to move the top node one time to the next node in the stack.
        and for peek just returning the top node data. and for the isempty method by returning true or false if the stack is empty will return true 
        or if it is not empty it gonna return false.


        - so the summary of the big O notation is O(1) for the this methods in the stack class and also the space will be O(1)

- ### Solution

    - here are some screen shots for my code :camera:

    - ![Code1](./Code1.png)
    - ![cod2](./code.png)
    - ![Visual Output](./output.png)


- # psudo queue code challenge 11 
    ### Approach & Efficiency

    - What approach did you take? Why? What is the Big O space/time for this approach

        - The Enqueue method simply pushes the new element onto stack1, as it represents the rear end of the queue.
        - The Dequeue method moves all elements from stack1 to stack2 recursively until the last element is reached. This effectively reverses the order of the elements, allowing the front element to be popped from stack2.
        - After popping the front element, the remaining elements are moved back from stack2 to stack1 in their original order.


        - so the summary of the big O notation is O(n) for the this methods and the space is seems to be O(n)

- ### Solution

    - here are some screen shots for my code :camera:

    - ![Code1](./psudoqueue.png)
    - ![Visual Output](./output2.png)