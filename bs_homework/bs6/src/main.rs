use std::io;

fn main() {
    let sides = input_values();
    let medians = solution((sides.0, sides.1, sides.2));

    println!("{}", medians.0);
    println!("{}", medians.1);
    println!("{}", medians.2);
}

fn input_values() -> (f32, f32, f32) {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    let values: Vec<f32> = input_line
    .split_whitespace()
        .map(|q| q.parse().unwrap())
        .collect();
    (values[0], values[1], values[2],)
}

fn solution(sides: (f32, f32, f32)) -> (f32, f32, f32) {
    let (a,b,c) = sides;
    
    let median_a: f32 = 0.5*(2.*b.powi(2)+2.*c.powi(2)-a.powi(2)).sqrt();
    let median_b: f32 = 0.5*(2.*a.powi(2)+2.*c.powi(2)-b.powi(2)).sqrt();
    let median_c: f32 = 0.5*(2.*a.powi(2)+2.*b.powi(2)-c.powi(2)).sqrt();

    ((median_a),(median_b),(median_c))
}