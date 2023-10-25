use std::io;
fn main() {
    for i in 1..=input_line().trim().parse().unwrap() { print!("{} ",(((8.0*i as f64 - 7.0).sqrt() + 1.0)/2.0).floor()); }
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}