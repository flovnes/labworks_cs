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
    loop {
        let current_element: i16 = input_line().trim().parse().unwrap();
        if current_element == 0 {break}
        if current_element.abs() % 2 == 1  { 
            counter+=1;
        }
    }
    counter
}