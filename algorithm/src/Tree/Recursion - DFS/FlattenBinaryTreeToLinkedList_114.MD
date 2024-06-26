
<img height="150" src="https://i.gyazo.com/f471a7ec5c7e30540a1324fbd661cc59.png" width="400"/>
Need to be in-order: &nbsp; &nbsp; root -> left -> right

Assuming we have already flattened the left subtree and right subtree, how can we connect and move the left subtree to the right subtree?

| Input Root | Base Case | Recursive Case           | Recursive Action              |
|------------|-----------|--------------------------|-------------------------------|
| 1          |           | Start to flatten 1.left  |                               |
| 2          |           | Start to flatten 2.left  |                               |
| 3          |           | Start to flatten 3.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 3.right |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 2.right |                               |
| 4          |           | Start to flatten 4.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 4.right |                               |
|            | Return    |                          |                               |
|            |           |                          | store `root.right` as temp: 4 |            
|            |           |                          | root.right = root.left: 3     |
|            |           |                          | root.right = temp: 4          |
|            |           | start to flatten 1.right |                               |
| 5          |           | Start to flatten 5.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 5.right |                               |
| 6          |           | Start to flatten 6.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 6.right |                               |
|            | Return    |                          |                               |
|            |           |                          | store `root.right` as temp: 5 |
|            |           |                          | root.right = root.left: 2     |
|            |           |                          | root.right = temp: 5          |

1. Flatten the left subtree  
   <img height="250" src="https://i.gyazo.com/6b13b0c0d57c0f5fa19490273d2cb8e6.png" width="600"/>

2. Flatten the right subtree  
   <img height="250" src="https://i.gyazo.com/572b150c136d111c71b18615230c696a.png" width="700"/>
3. Finally, connect the left subtree to the right subtree  
<img height="250" src="https://i.gyazo.com/ca040711988427366670c8a617685f7e.png" width="600"/>

Recursion action:
1. Store the right subtree as a temp variable
2. Make the left subtree to be the right subtree
3. Connect the temp variable to the right subtree

<img height="350" src="https://i.gyazo.com/124f3f0c6b5fad18a52e58b07b4154cf.png" width="600"/>
