use std::io;
use std::convert::TryInto;
// removed some dumb stuff, works properly now ^^
//
    // println!("List of owned cubes: {:?}.", owned_cubes);
    // println!("{} is the missing cube.", find_missing(cubes, owned_cubes));

fn main() {
    let owned_cubes: Vec::<u8> = input_owned();

    println!("{}", find_missing(owned_cubes));
}

// what does it do?
    // '1','','2','','3','\r','\n' -> [1,2,3]
fn input_owned() -> Vec::<u8> {
    let mut owned_cubes = Vec::<u8>::new();
    let mut input_cubes = String::new();

// why?
    // .read_line() returns Result so we have to get rid of it
    let _ = io::stdin().read_line(&mut input_cubes);

// why?
    // .to_digit(10).unwrap() means "from char to u32"
    // .try_into().unwrap() means  "from u32 to u8"
    // .unwrap() means unwrap value from Option(Ok, Err)
    // im throwing away Err part, because input is expected to be always correct
    // .to_digit(x) means x system, 10 for decimal, 2 for binary, 16 hex etc.
    for char in input_cubes.chars() 
    {
        match char 
        {
            '\r'|'\n' => break,
            ' ' => (),
            _ => owned_cubes.push(char.to_digit(10).unwrap().try_into().unwrap()) 
        }
    }
    owned_cubes
}

// what does it do?
    // {1,2,3,4,5} |
    //             |  => {4}
    // {1,2,3,5}   | 

// okay that didn't work. 
// we now .iter()ate through all cubes,
// .filter() out identical ones,
// .collect() them in a vec from Filter,
// and .pop() the result
fn find_missing(own_cubes: Vec<u8>) -> u8 {
    let cubes: Vec<u8> = vec![1,2,3,4,5];
    cubes.iter().filter(|&q| !own_cubes.contains(q)).cloned().collect::<Vec<u8>>().pop().unwrap()
}
     

// why?
    // .clone() cause .pop() borrows cubes[] later in the loop
    // .rev() cause we want to start from the last index to use .pop()
    // for cubei in bind.iter().rev() 
    // {
    //     let mut counter = 0;
    //     for own_cubei in own_cubes.iter().rev() 
    //     {
    //     // why?
    //         // .pop() cause we don't wanna index'es to shift on element remove

    //     // what does it do?
    //         // 1. we take a cube that should be in our vec
    //         // 2. we compare it to every cube we have
    //         // 3. if expected cube is equal to a cube we have, we remove it from both sets
    //         // 4. if we don't find an equal cube through while going through our "owned cubes" set, then the missing cube is the one that we are currently comparing 
    //         // base case example:
    //         // *don't forget that we compare down from 5 to 1
    //         // expected:  1 (2) 3 4 5 - we are currently comparing cube (2) 
    //         // inputted: (4) 5 1 3 - to cube (4), we compared cube "2" to every cube we have, and cube "4" is the last one in the loop, therefore cube "2" is the missing one
    //         counter += 1;
    //         if *cubei == *own_cubei {
    //             let _ = cubes.pop(); // why? -> .pop() returns Option so we get rid of it wia let _ =
    //             let _ = own_cubes.remove();
    //             break;
    //         } else {
    //             if counter == own_cubes.len() { // why? -> own_cubei is of type <&u8>, can't compare it to '1' of <u8>
    //                 missing_cube = *cubei;
    //                 return missing_cube;
    //             }
    //         }
    //     }
    //     last_idx = cubei;
    // }
    // *last_idx
//}