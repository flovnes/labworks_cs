use std::io;

fn main() {
    let (perimeter, length, width) = input_values();

    println!("{}", solution(perimeter, length/width));
}

fn input_values() -> (f32, f32, f32) {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    let values: Vec<f32> = input_line
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1], values[2])
}

fn solution(perimeter: f32, ratio: f32) -> f32 {  
    ratio*perimeter.powi(2)/(4.*ratio.powi(2)+8.*ratio+4.)
}

//  | 2x + 2y = P
//  | x/y = k 
//  | xy = S
//  => S = k*y^2
//  | 2ky + 2y = P
//  | y = P/(2k+2)
//  | y^2 = P^2/(4k^2+8k+4)
//  => S = kP^2/(4k^2+8k+4)