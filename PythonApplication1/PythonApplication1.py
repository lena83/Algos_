def reverse_with_stack(s):
    stack = list(s)
    result = ''
    while stack:
        result += stack.pop()
    return result


def ReverseString(a):
    stack = []
    result = ""
    
    for char in a:
        stack.append(char)
    
    while stack:
        popped_item = stack.pop()
        result += popped_item
        
    return result

def ReverseString_v2(a):
    left = 0
    right = len(a) - 1
    result = ""
    char_array = [char for char in a]
    while (left < right):
        temp = char_array[left]
        char_array[left] = char_array[right]
        char_array[right] = temp
        left = left +1 
        right = right-1         
   
    return ''.join(char_array)

def ReverseString_v3(a):
    char_array = list(a)  
    left, right = 0, len(char_array) - 1 

    while left < right:
        char_array[left], char_array[right] = char_array[right], char_array[left]
        left += 1
        right -= 1

    return ''.join(char_array) 

a = ReverseString("hello")
print(a)

b = ReverseString_v2("hello")
print(b)