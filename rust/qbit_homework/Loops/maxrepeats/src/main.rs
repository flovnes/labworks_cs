use std::io;
fn main() {
    println!("{}", solution());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() -> i16 {
    let mut counter = 0;
    let mut max_sequence = 1;
    let mut previous_element = i16::MAX;
    let mut empty_input = true;
    loop {
        let current_element: i16 = input_line().trim().parse().unwrap();

        if current_element == 0 && previous_element == 0 { break }
        
        if current_element == previous_element { 
            empty_input = false;
            counter +=1;
        } 
        else {
            if counter > max_sequence { max_sequence = counter; }
            counter = 1;
        }
        previous_element = current_element;
    }
    if empty_input { return 0; }
    max_sequence
}