import { render, screen } from '@testing-library/react';
import App from './App';

describe('The main app', () => {
  it('renders learn react link', () => {
    render(<App />);
    const linkElement = screen.getByText(/learn react/i);
    expect(linkElement).toBeInTheDocument();
  });

  it('renders Orders component', () => {
    render(<App />);
    const ordersElement = screen.getByText(/Orders/i);
    expect(ordersElement).toBeInTheDocument();
  });

  it('renders Payments component', () => {
    render(<App />);
    const paymentsElement = screen.getByText(/Payments/i);
    expect(paymentsElement).toBeInTheDocument();
  });

  it('should render the Home link', () => {
    render(<App />);
    expect(screen.getByRole('link', { name: /Home/i })).toBeInTheDocument();
  });

  it('should render the header', () => {
    render(<App />);
    expect(screen.getByRole('heading', { level: 2 })).toBeInTheDocument();
  });
});