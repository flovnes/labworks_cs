use std::io;

fn main() {
    let radius = input_radius();

    println!("{}", solution(radius).0);
    println!("{}", solution(radius).1);
}

fn input_radius() -> u32 {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line.trim().parse().unwrap()
}

fn solution(radius: u32) -> (f64, f64) {
    use std::f64::consts::PI as pi;
    (pi*f64::from(radius).powi(2), 2.*pi*f64::from(radius))
}