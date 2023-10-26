use std::io;
fn main() {
    solution();
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() {
    let n: i16 = input_line().trim().parse().unwrap();
    for current_number in 1..=n {
        if current_number % 2 == 0  { 
            print!("{} ", current_number)
        }
    }
}