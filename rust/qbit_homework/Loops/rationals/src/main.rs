use std::io;

fn main() {
    let n: u8 = input_line().trim().parse().unwrap();
    println!("{0:0.06}", solution(n));
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution(n: u8) -> f64 {
    let mut product = 1.;
    
    for i in 0..=n {
        product *= 1.0+0.1*i as f64;
    }
    product
}