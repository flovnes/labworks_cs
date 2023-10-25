use std::io;
fn main() {
    let n: u64 = input_line().trim().parse().unwrap();
    println!("{}", (n as f64).log(2.0).ceil());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}