use std::io;
fn main() {
    println!("{}", solution());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() -> i32 {
    let mut sum = 0;
    loop {
        let current_element: i32 = input_line().trim().parse().unwrap();
        if current_element == 0 {break}
        sum+=current_element;
    }
    sum
}