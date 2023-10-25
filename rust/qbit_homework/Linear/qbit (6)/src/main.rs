use std::io;

fn main() {
    let points = input_coordinates();

    println!("{}", solution(points.0,points.1));
}

fn input_coordinates() -> ((f32,f32),(f32,f32)) {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    let values: Vec<f32> = input_line
    .split_whitespace()
        .map(|q| q.parse().unwrap())
        .collect();
    ((values[0], values[1]), (values[2], values[3]))
}

fn solution(point1: (f32, f32), point2: (f32, f32)) -> f32 {
    ((point1.0-point2.0).powi(2)+(point1.1-point2.1).powi(2)).sqrt()
}