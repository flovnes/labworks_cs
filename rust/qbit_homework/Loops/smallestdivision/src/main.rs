use std::io;
fn main() {
    println!("{0}", solution());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() -> u64 {
    let number: u64 = input_line().trim().parse().unwrap();
    for i in 1..=(number as f64).sqrt() as u64 {
        if number % i == 0 && i != 1 {
            return i
        }
        if number % (number/i) == 0 && i != 1 {
            return number/i;
        }
    }
    number
}