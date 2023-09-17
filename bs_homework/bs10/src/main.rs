use std::io;

fn main() {
    let (v_forward_1, v_forward_2, v_back_1, v_back_2): (f32, f32, f32, f32) = input_coordinates();
    let v_forw = (v_forward_1, v_forward_2);
    let v_back = (v_back_1, v_back_2);
    let (avg_forwards, avg_backwards) = solution(v_forw, v_back);

    println!("{}", avg_forwards);
    println!("{}", avg_backwards);
}

fn input_coordinates() -> (f32,f32,f32,f32) {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    let values: Vec<f32> = input_line
    .split_whitespace()
        .map(|q| q.parse().unwrap())
        .collect();
    (values[0], values[1], values[2], values[3])
}

fn solution(velocities_forwards: (f32,f32), velocities_backwards: (f32,f32)) -> (f32,f32) {
    let (v1, v2) = velocities_forwards;
    let (v3, v4) = velocities_backwards;
    ((v1 + v2)/2.,2.*v3*v4/(v3+v4))
}