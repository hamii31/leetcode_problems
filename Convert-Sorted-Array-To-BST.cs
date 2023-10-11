 TreeNode SortedArrayToBST(int[] nums)
            {
                if (nums.Length == 0)
                    return null;

                int n = nums.Length;
                int mid = n / 2; // initial root position

                TreeNode root = new TreeNode(nums[mid]);

                Queue<Tuple<TreeNode, Tuple<int, int>>> queue = new Queue<Tuple<TreeNode, Tuple<int, int>>>();

                queue.Enqueue(new Tuple<TreeNode, Tuple<int, int>>(root, new Tuple<int, int>(0, mid - 1))); // enqueue the elements to the left of the initial root

                queue.Enqueue(new Tuple<TreeNode, Tuple<int, int>>(root, new Tuple<int, int>(mid + 1, n - 1))); // enqueue the elements to the right of the initital root

                while (queue.Count != 0)
                {
                    Tuple<TreeNode, Tuple<int, int>> frontElement = queue.Dequeue();

                    TreeNode parent = frontElement.Item1;
                    int left = frontElement.Item2.Item1;
                    int right = frontElement.Item2.Item2;

                    if (left <= right && parent != null)
                    {
                        mid = (left + right) / 2;

                        TreeNode child = new TreeNode(nums[mid]);

                        if (nums[mid] < parent.val)
                            parent.left = child;
                        else
                            parent.right = child;

                        queue.Enqueue(new Tuple<TreeNode, Tuple<int, int>>(child, new Tuple<int, int>(left, mid - 1)));
                        
                        queue.Enqueue(new Tuple<TreeNode, Tuple<int, int>>(child, new Tuple<int, int>(mid + 1, right)));
                    }
                }
                return root;
            }
